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
        delegate void SetTextCallback(Label labe, string text);

        //Values that won't change
        readonly byte[] ButtonStatusCheck = { 0, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x02 };
        readonly byte[] ButtonDown = { 0x16, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x03 };
        readonly byte[] ButtonUp = { 0x17, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x03 };

        public MainForm()
        {
            InitializeComponent();

            string registry_key = @"SOFTWARE\Microsoft\Windows\CurrentVersion\App Paths";
            using (Microsoft.Win32.RegistryKey key = Registry.LocalMachine.OpenSubKey(registry_key))
            {
                foreach (string subkey_name in key.GetSubKeyNames())
                {
                    using (RegistryKey subkey = key.OpenSubKey(subkey_name))
                    {
                        string DisplayPath = (string)subkey.GetValue(null);
                        if (!string.IsNullOrEmpty(DisplayPath))
                        {
                            string DisplayName = ProcessTools.GetFileNameFromPath(DisplayPath);
                            ProcessesComboBox.Items.Add(DisplayName);
                        }
                    }
                }
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
        private void StartButton_Click(object sender, EventArgs e)
        {
            String VIDString = VIDTextBox.Text;
            String PIDString = PIDTextBox.Text;

            //Parse the HEX of the VID and PID
            VID = Int32.Parse(VIDString, System.Globalization.NumberStyles.AllowHexSpecifier);
            int PID = Int32.Parse(PIDString, System.Globalization.NumberStyles.AllowHexSpecifier);
            
            //Because PID has to be in an array
            PIDArray = new int[1];
            PIDArray[0] = PID;

            String Macro = MacroTextBox.Text;

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
                this.Invoke(
                    new MethodInvoker(
                    delegate() { OnRead(report); }));
            }
            else
            {
                Console.WriteLine(ProcessTools.GetProcessExecutableName(ProcessTools.GetForegroundProcess()));

                //If the foreground application matches the one we selected, continue, if not stop
                if (ProcessesComboBox.Text != "" && ProcessesComboBox.Text != ProcessTools.GetProcessExecutableName(ProcessTools.GetForegroundProcess()))
                    return;

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

                //Button was just pressed
                if (buttonPressed && !wasButtonPressed)
                {
                    Console.WriteLine("Button Pressed");
                    SendKeys.Send(MacroTextBox.Text);
                }
                //Button was just release
                else if (!buttonPressed && wasButtonPressed)
                {
                    Console.WriteLine("Button Released");
                    SendKeys.Flush();
                }

                //Save for next poll
                wasButtonPressed = buttonPressed;
            }
        }

        /// <summary>
        /// Stops the HID thread
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void StopButton_Click(object sender, EventArgs e)
        {
            StopTimer();
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
        /// Every few milliseconds check to see if we can use our macro based on what application is in the foreground
        /// </summary>
        private void ApplicationTimer_Tick(object sender, EventArgs e)
        {
            
        }

    }
}
