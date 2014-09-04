using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using HidLibrary;
using System.Diagnostics;

//#if WINDOWS
using Microsoft.Win32;
//#endif

namespace BigRedButton
{
    public partial class MainForm : Form
    {
        HidDevice[] HidDeviceList;
        HidDevice HidDevice;

        int VID;
        int[] PIDArray;

        bool buttonPressed = false;
        bool wasButtonPressed = false;

        //For threadsafe value changing
        delegate void SetTextCallback(Label label, string text);

        //Values that won't change
        readonly byte[] ButtonStatusCheck = { 0, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x02 };

        //Defaults that can be changed by the user if they really want to 
        byte[] ButtonDown = { 0x16, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x03 };
        byte[] ButtonUp = { 0x17, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x03 };

        public MainForm()
        {
            InitializeComponent();

            string registry_key = @"SOFTWARE\Microsoft\Windows\CurrentVersion\App Paths";
            using (Microsoft.Win32.RegistryKey key = Registry.LocalMachine.OpenSubKey(registry_key))
            {
                List<string> displayNames = new List<string>();
                //Add "None" option for the macro to fire no matter what application is in focus
                displayNames.Add("None");

                foreach (string subkey_name in key.GetSubKeyNames())
                {
                    using (RegistryKey subkey = key.OpenSubKey(subkey_name))
                    {
                        string DisplayPath = (string)subkey.GetValue(null);
                        if (!string.IsNullOrEmpty(DisplayPath))
                        {
                            string DisplayName = ProcessTools.GetFileNameFromPath(DisplayPath);
                            displayNames.Add(DisplayName);
                        }
                    }
                }

                //Store the list of applications in the Macro class for when Macros are added to the form
                Macro.Applications = displayNames;
            }
        }

        /// <summary>
        /// Resets the VIDTextBox text back to 1D34 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void VIDResetButton_Click(object sender, EventArgs e)
        {
            VIDTextBox.Text = "1D34";
        }

        /// <summary>
        /// Resets the PIDTextBox text back to 000D 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PIDResetButton_Click(object sender, EventArgs e)
        {
            PIDTextBox.Text = "000D";
        }

        /// <summary>
        /// Applies the given macro to the HID controller at the given VID and PID
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void StartStopButton_Click(object sender, EventArgs e)
        {
            //If the Poll Timer is running, stop, otherwise check the button status and start polling if it's available
            if (PollTimer.Enabled)
            {
                StopTimer();

                StartStopButton.Text = "Start";
            }
            else
            {
                //If there are no macros, let the user know and don't start the timer
                if (Macro.Macros == null)
                {
                    MessageBox.Show("Please add a Macro :)");
                    return;
                }

                String VIDString = VIDTextBox.Text;
                String PIDString = PIDTextBox.Text;

                //Parse the HEX of the VID and PID
                int PID = 0;
                try
                {
                    VID = Int32.Parse(VIDString, System.Globalization.NumberStyles.AllowHexSpecifier);
                    PID = Int32.Parse(PIDString, System.Globalization.NumberStyles.AllowHexSpecifier);
                }
                catch (Exception exception)
                {
                    MessageBox.Show("Check your VID and PID. They need to be valid Hex.");
                    return;
                }

                //Because PID has to be in an array
                PIDArray = new int[1];
                PIDArray[0] = PID;

                //String Macro = MacroTextBox.Text;

                //Enumerate the HIDs on the given VID and PID
                HidDeviceList = HidDevices.Enumerate(VID, PIDArray).ToArray();

                //If there are no devices, lets let the user know and stop
                if (HidDeviceList.Length <= 0)
                {
                    MessageBox.Show("No devices found with that VID and PID :(");
                    return;
                }

                //Otherwise we've found our button!

                //Get the HID
                HidDevice = HidDeviceList[0];

                //Enable the system timer
                PollTimer.Enabled = true;

                StatusLabel.Text = "Status: Running";
                StartStopButton.Text = "Stop";
            }
            
        }

        /// <summary>
        /// Executes every 100ms on System Timer
        /// Polls Button for input
        /// </summary>
        /// 
        private void ButtonPoll(object sender, EventArgs e) 
        {
            //Double check that it's still connected
            HidDeviceList = HidDevices.Enumerate(VID, PIDArray).ToArray();
            if (HidDeviceList.Length <= 0)
            {
                StopTimer();
                return;
            }

            //Write out to the Button to check its status
            HidDevice.Write(ButtonStatusCheck);

            //Check what its current state is
            HidDevice.ReadReport(OnRead);
        }

        /// <summary>
        /// Called by HidDevice.ReadReport when a value is read from the button
        /// </summary>
        /// <param name="report">The read data</param>
        private void OnRead(HidReport report) 
        {
            //Make this threadsafe
            if (this.InvokeRequired)
            {
                //This is just to make sure the application can gracefully close
                //Without the try/catch, the application will crash on close
                try
                {
                    this.Invoke(
                        new MethodInvoker(
                        delegate() { OnRead(report); }));
                }
                catch (ObjectDisposedException e)
                { }
            }
            else
            {
                Console.WriteLine(ProcessTools.GetProcessExecutableName(ProcessTools.GetForegroundProcess()));
                
                //Set the ButtonDown and ButtonUp states to whatever is in the text boxes
                ButtonDown = PressedStateTextBox.Text.Split(' ').Select(s => Convert.ToByte(s, 16)).ToArray();
                ButtonUp = ReleasedStateTextBox.Text.Split(' ').Select(s => Convert.ToByte(s, 16)).ToArray();

                //Get the data from the report
                byte[] state = report.Data.ToArray();

                if (state == null)
                    return;

                //Show the current state on the text box
                CurrentStateTextBox.Text = ByteArrayToString(state);

                //Determine button state
                if (Enumerable.SequenceEqual(state, ButtonDown))
                    buttonPressed = true;
                else if (Enumerable.SequenceEqual(state, ButtonUp))
                    buttonPressed = false;

                //This will execute the keystrokes depending on the macro's given settings
                ExecuteMacros();

                //Save for next poll
                wasButtonPressed = buttonPressed;
            }
        }

        private void ExecuteMacros() 
        {
            foreach (Macro m in Macro.Macros)
            {
                //If the foreground application matches the one in the macro or is "None", continue
                if (m.ApplicationComboBox.Text != "None" && m.ApplicationComboBox.Text != ProcessTools.GetProcessExecutableName(ProcessTools.GetForegroundProcess()))
                    continue;

                //If the macro is set to repeat presses, the logic is going to be slightly different
                if (m.RepeatCheckBox.Checked)
                {
                    if (buttonPressed)
                    {

                        SendKeys.Send(m.MacroTextBox.Text);
                        SendKeys.Flush();

                        Thread.Sleep(5);
                    }
                }
                else 
                {
                    //Button was just pressed
                    if (buttonPressed && !wasButtonPressed)
                    {
                        Console.WriteLine("Button Pressed");
                        SendKeys.Send(m.MacroTextBox.Text);
                    }
                    //Button was just released
                    else if (!buttonPressed && wasButtonPressed)
                    {
                        Console.WriteLine("Button Released");
                        SendKeys.Flush();
                    }
                }
            }
        }

        /// <summary>
        /// Properly stops the thread ASAP
        /// </summary>
        private void StopTimer() 
        {
            PollTimer.Enabled = false;

            StatusLabel.Text = "Status: Idle";
            CurrentStateTextBox.Text = "Unavailable";
        }

        /// <summary>
        /// Converts a byte array from the button to a string that we want to read
        /// </summary>
        /// <returns>A Readable String</returns>
        private string ByteArrayToString(byte[] data) 
        {
            string readableData = "";

            for (int i = 0; i < data.Length; i++) 
            {
                    readableData += " 0x" + BitConverter.ToString(data, i, 1);
            }

            return readableData;
        }

        /// <summary>
        /// Toggle whether or not the user wants to edit the state data
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AdvancedCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (AdvancedCheckBox.Checked)
            {
                PressedStateTextBox.ReadOnly = false;
                ReleasedStateTextBox.ReadOnly = false;
            }
            else 
            {
                PressedStateTextBox.ReadOnly = true;
                ReleasedStateTextBox.ReadOnly = true;

                PressedStateTextBox.Text = "0x16 0x00 0x00 0x00 0x00 0x00 0x00 0x03";
                ReleasedStateTextBox.Text = "0x17 0x00 0x00 0x00 0x00 0x00 0x00 0x03";
            }
        }

        /// <summary>
        /// Add a new macro to the MacroPanel
        /// </summary>
        private void AddMacroButton_Click(object sender, EventArgs e)
        {
            Macro macro = new Macro();
            macro.CreateControls(MacrosPanel);
        }
    }
}
