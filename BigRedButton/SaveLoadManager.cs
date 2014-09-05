using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

using Newtonsoft.Json;

namespace BigRedButton
{
    class SaveLoadManager
    {
        private static string lastSaveFile;

        /// <summary>
        /// Load the settings for the application
        /// Called at start
        /// </summary>
        public static void LoadSettings()
        {
            //End if there are no settings
            if (!File.Exists("settings"))
                return;

            StreamReader reader = new StreamReader("settings");
            string json = reader.ReadToEnd();
            reader.Close();

            JsonTextReader jsonReader = new JsonTextReader(new StringReader(json));

            jsonReader.Read(); //Read Start of Object
            jsonReader.Read(); //Read Token
            jsonReader.ReadAsInt32();
            MainForm.Form.Width = (int)jsonReader.Value;
            jsonReader.Read(); //Read Token
            jsonReader.ReadAsInt32();
            MainForm.Form.Height = (int)jsonReader.Value;
            jsonReader.Read(); //Read Token
            jsonReader.ReadAsInt32();
            int locX = (int)jsonReader.Value;
            jsonReader.Read(); //Read Token
            jsonReader.ReadAsInt32();
            int locY = (int)jsonReader.Value;

            MainForm.Form.DesktopLocation = new System.Drawing.Point(locX, locY);

            jsonReader.Read(); //Read Token
            jsonReader.ReadAsString();
            string filename = (string)jsonReader.Value;

            if (File.Exists(filename) && !string.IsNullOrEmpty(filename))
            {
                LoadMacroFile(filename);
            }
        }

        /// <summary>
        /// Save the settings for the application
        /// Called at close
        /// </summary>
        public static void SaveSettings() 
        {
            //Build settings into json string
            StringBuilder stringBuilder = new StringBuilder();
            StringWriter stringWriter = new StringWriter(stringBuilder);

            JsonTextWriter jsonWriter = new JsonTextWriter(stringWriter);

            jsonWriter.Formatting = Formatting.Indented;

            jsonWriter.WriteStartObject();
            jsonWriter.WritePropertyName("WindowWidth");
            jsonWriter.WriteValue(MainForm.Form.Width);
            jsonWriter.WritePropertyName("WindowHeight");
            jsonWriter.WriteValue(MainForm.Form.Height);
            jsonWriter.WritePropertyName("WindowX");
            jsonWriter.WriteValue(MainForm.Form.Location.X);
            jsonWriter.WritePropertyName("WindowY");
            jsonWriter.WriteValue(MainForm.Form.Location.Y);
            jsonWriter.WritePropertyName("LastSave");
            jsonWriter.WriteValue(lastSaveFile);
            jsonWriter.WriteEndObject();

            //Write json out to file
            try
            {
                using (StreamWriter jsonFile = new StreamWriter("settings"))
                {
                    jsonFile.Write(stringBuilder.ToString());
                    jsonFile.Close();
                }
            }
            catch (Exception e) 
            {
                Console.WriteLine("Could not write out settings: " + e.Message);
            }
        }

        /// <summary>
        /// Load the macros and the settings for said macros
        /// </summary>
        public static void LoadMacroSettings() 
        {
            //Open a file dialog to get the file we want to load
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Title = "Open Macros";
            dialog.Filter = "JSON Files|*.json";

            DialogResult result = dialog.ShowDialog();
            
            if (result == DialogResult.OK)
            {
                string filename = dialog.FileName;

                LoadMacroFile(filename);
            }
        }

        /// <summary>
        /// Load macro settings from a given file as a JsonObject
        /// </summary>
        private static void LoadMacroFile(string filename) 
        {
            string json;
            List<Macro> macros = new List<Macro>();

            //Try to load the file
            try
            {
                StreamReader r = new StreamReader(filename);
                json = r.ReadToEnd();
                r.Close();
            }
            catch (JsonException e)
            {
                MessageBox.Show("Failed to read save file");
                return;
            }

            JsonTextReader jsonReader = new JsonTextReader(new StringReader(json));

            //Read the basic settings
            jsonReader.Read(); //Read Start of Object
            jsonReader.Read(); //Read Token
            jsonReader.ReadAsString();
            MainForm.Form.VIDTextBox.Text = (string)jsonReader.Value;
            jsonReader.Read(); //Read Token
            jsonReader.ReadAsString();
            MainForm.Form.PIDTextBox.Text = (string)jsonReader.Value;
            jsonReader.Read(); //Read Token
            jsonReader.Read();
            MainForm.Form.AdvancedCheckBox.Checked = (bool)jsonReader.Value;
            jsonReader.Read(); //Read Token
            jsonReader.ReadAsString();
            MainForm.Form.PressedStateTextBox.Text = (string)jsonReader.Value;
            jsonReader.Read(); //Read Token
            jsonReader.ReadAsString();
            MainForm.Form.ReleasedStateTextBox.Text = (string)jsonReader.Value;

            jsonReader.Read();

            //Remove all previous macros
            MainForm.Form.MacrosPanel.Controls.Clear();
            if(Macro.Macros != null)
                Macro.Macros.Clear();

            //Read the array of Macros
            while (jsonReader.Read()) 
            {
                if (jsonReader.Value == null)
                    continue;

                Macro m = new Macro();

                jsonReader.ReadAsInt32();
                m.index = (int)jsonReader.Value;

                m.CreateControls(MainForm.Form.MacrosPanel);

                jsonReader.Read();//Read Token
                jsonReader.ReadAsString();
                m.MacroTextBox.Text = (string)jsonReader.Value;
                jsonReader.Read();//Read Token
                jsonReader.ReadAsString();
                m.ApplicationComboBox.Text = (string)jsonReader.Value;
                jsonReader.Read(); //Read Token
                jsonReader.Read();
                m.RepeatCheckBox.Checked = (bool)jsonReader.Value;

                Macro.Macros.Add(m);
            }

            lastSaveFile = filename;
        }

        /// <summary>
        /// Save out the macros and the settings for said macros
        /// </summary>
        public static void SaveMacroSettings() 
        {
            string filename;

            //Open a file dialog to get the file we want to load
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Title = "Open Macros";
            dialog.Filter = "JSON Files|*.json";

            DialogResult result = dialog.ShowDialog();

            if (result == DialogResult.OK)
                filename = dialog.FileName;
            else
                return;
            

            //Build settings into json string
            StringBuilder stringBuilder = new StringBuilder();
            StringWriter stringWriter = new StringWriter(stringBuilder);

            JsonTextWriter jsonWriter = new JsonTextWriter(stringWriter);

            jsonWriter.Formatting = Formatting.Indented;

            jsonWriter.WriteStartObject();
            jsonWriter.WritePropertyName("VID");
            jsonWriter.WriteValue(MainForm.Form.VIDTextBox.Text);
            jsonWriter.WritePropertyName("PID");
            jsonWriter.WriteValue(MainForm.Form.PIDTextBox.Text);
            jsonWriter.WritePropertyName("Advanced");
            jsonWriter.WriteValue(MainForm.Form.AdvancedCheckBox.Checked);
            jsonWriter.WritePropertyName("PressedState");
            jsonWriter.WriteValue(MainForm.Form.PressedStateTextBox.Text);
            jsonWriter.WritePropertyName("ReleasedState");
            jsonWriter.WriteValue(MainForm.Form.ReleasedStateTextBox.Text);

            jsonWriter.WritePropertyName("Macros");
            jsonWriter.WriteStartArray();
            if (Macro.Macros != null && Macro.Macros.Count > 0)
            {
                foreach (Macro m in Macro.Macros)
                {
                    jsonWriter.WriteStartObject();
                    jsonWriter.WritePropertyName("Index");
                    jsonWriter.WriteValue(m.index);
                    jsonWriter.WritePropertyName("Keys");
                    jsonWriter.WriteValue(m.MacroTextBox.Text);
                    jsonWriter.WritePropertyName("Application");
                    jsonWriter.WriteValue(m.ApplicationComboBox.Text);
                    jsonWriter.WritePropertyName("Repeat");
                    jsonWriter.WriteValue(m.RepeatCheckBox.Checked);
                    jsonWriter.WriteEndObject();
                }
            }
            jsonWriter.WriteEnd();

            jsonWriter.WriteEndObject();

            //Write json out to file
            try
            {
                using (StreamWriter jsonFile = new StreamWriter(filename))
                {
                    jsonFile.Write(stringBuilder.ToString());
                    jsonFile.Close();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Could not write out macro settings: " + e.Message);
            }

            lastSaveFile = filename;
        }


    }
}
