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
            Console.WriteLine(json);

            JsonTextReader jsonReader = new JsonTextReader(new StringReader(json));

            jsonReader.Read();
            jsonReader.Read();
            jsonReader.ReadAsInt32();
            MainForm.Form.Width = (int)jsonReader.Value;
            jsonReader.Read();
            jsonReader.ReadAsInt32();
            MainForm.Form.Height = (int)jsonReader.Value;
            jsonReader.Read();
            jsonReader.ReadAsInt32();
            int locX = (int)jsonReader.Value;
            jsonReader.Read();
            jsonReader.ReadAsInt32();
            int locY = (int)jsonReader.Value;

            MainForm.Form.Location = new System.Drawing.Point(locX, locY);

            jsonReader.Read();
            jsonReader.ReadAsString();
            string filename = (string)jsonReader.Value;

            if (!string.IsNullOrEmpty(filename))
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
                }
            }
            catch (Exception e) 
            {
                Console.WriteLine("Could not write out settings");
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
            List<Macro> macros;

            //Try to load the file
            try
            {
                StreamReader r = new StreamReader(filename);

                string json = r.ReadToEnd();
                macros = JsonConvert.DeserializeObject<List<Macro>>(json);
            }
            catch (JsonException e)
            {
                MessageBox.Show("Failed to open Saved Macros");
                return;
            }

            //If we're all set, we can set the macros
            Macro.Macros = macros;

            //Setup all the controls for the loaded macros
            foreach (Macro m in Macro.Macros)
                m.CreateControls(MainForm.Form.MacrosPanel);
        }

        /// <summary>
        /// Save out the macros and the settings for said macros
        /// </summary>
        public static void SaveMacroSettings(string filename) 
        {

            lastSaveFile = filename;
        }


    }
}
