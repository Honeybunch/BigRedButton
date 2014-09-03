using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BigRedButton
{
    /// <summary>
    /// Defines a key to be pressed and other info about it, as well as all the controls that are associated with the macro
    /// </summary>
    class Macro
    {
        /// <summary>
        /// A Singleton list of all macros
        /// </summary>
        public static List<Macro> Macros;

        /// <summary>
        /// A Singleton list of all applications installed on the system 
        /// </summary>
        public static List<string> Applications;

        /// <summary>
        /// The place in the singleton that this macro is at
        /// </summary>
        public int index;

        //Macro data
        private string keys;
        private string application;
        private bool repeat;

        //The Controls
        public Label MacroLabel;
        public TextBox MacroTextBox;
        public Label ApplicationLabel;
        public ComboBox ApplicationComboBox;
        public CheckBox RepeatCheckBox;
        public Button RemoveButton;

        /// <summary>
        /// The Keys that are supposed to be pressed by this macro
        /// </summary>
        public string Keys 
        {
            get { return keys; }
            set { keys = value; }
        }
        /// <summary>
        /// The Application that this macro is set to exectue on
        /// </summary>
        public string Application 
        {
            get { return application; }
            set { application = value; }
        }

        /// <summary>
        /// Whether or not the macro will be continuously executed as the button is held
        /// </summary>
        public bool Repeat 
        {
            get { return repeat; }
            set { repeat = value; }
        }

        public Macro() 
        {
            if (Macros == null)
                Macros = new List<Macro>();
        }

        public void CreateControls(Control parent) 
        {
            index = Macros.Count;

            //Create controls
            MacroLabel = new Label();
            MacroTextBox = new TextBox();
            ApplicationLabel = new Label();
            ApplicationComboBox = new ComboBox();
            RepeatCheckBox = new CheckBox();
            RemoveButton = new Button();

            // 
            // MacroLabel
            // 
            this.MacroLabel.AutoSize = true;
            this.MacroLabel.Location = new System.Drawing.Point(0, 6 + (26 * index));
            this.MacroLabel.Name = "MacroLabel" + index + 1;
            this.MacroLabel.Size = new System.Drawing.Size(49, 13);
            this.MacroLabel.TabIndex = 8;
            this.MacroLabel.Text = "Macro " + (index+1) + ":";
            // 
            // MacroTextBox
            // 
            this.MacroTextBox.Location = new System.Drawing.Point(58, (3 * (index+1)) + (23 * index));
            this.MacroTextBox.Name = "MacroTextBox" + index;
            this.MacroTextBox.Size = new System.Drawing.Size(40, 20);
            this.MacroTextBox.TabIndex = 7;
            this.MacroTextBox.Text = "";
            this.MacroTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ApplicationLabel
            // 
            this.ApplicationLabel.AutoSize = true;
            this.ApplicationLabel.Location = new System.Drawing.Point(104, 6 + (26 * index));
            this.ApplicationLabel.Name = "ApplicationLabel" + index;
            this.ApplicationLabel.Size = new System.Drawing.Size(59, 13);
            this.ApplicationLabel.TabIndex = 19;
            this.ApplicationLabel.Text = "Application:";
            // 
            // ApplicationComboBox
            // 
            this.ApplicationComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ApplicationComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ApplicationComboBox.ItemHeight = 13;
            this.ApplicationComboBox.Location = new System.Drawing.Point(169, (3 * (index + 1)) + (23 * index));
            this.ApplicationComboBox.Name = "ApplicationComboBox" + index;
            this.ApplicationComboBox.Size = new System.Drawing.Size(204, 21);
            this.ApplicationComboBox.TabIndex = 18;
            // 
            // RepeatCheckBox
            // 
            this.RepeatCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.RepeatCheckBox.AutoSize = true;
            this.RepeatCheckBox.Location = new System.Drawing.Point(379, 5 + (26 * index));
            this.RepeatCheckBox.Name = "RepeatCheckBox" + index;
            this.RepeatCheckBox.Size = new System.Drawing.Size(101, 17);
            this.RepeatCheckBox.TabIndex = 22;
            this.RepeatCheckBox.Text = "Repeat on Hold";
            this.RepeatCheckBox.UseVisualStyleBackColor = true;
            // 
            // RemoveMacroButton
            // 
            this.RemoveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.RemoveButton.Location = new System.Drawing.Point(486, 1 + (26 * index));
            this.RemoveButton.Name = "RemoveMacroButton" + index;
            this.RemoveButton.Size = new System.Drawing.Size(63, 23);
            this.RemoveButton.TabIndex = 23;
            this.RemoveButton.Text = "Remove";

            //Add applications to the Applications ComboBox
            foreach(string s in Applications)
                ApplicationComboBox.Items.Add(s);

            //Set the current item in the combo box to be the first item; "None"
            this.ApplicationComboBox.SelectedItem = ApplicationComboBox.Items[0];

            //Add this macro to the macro list
            Macros.Add(this);

            //
            //Add controls to parent (Macro Panel probably)
            //
            parent.Controls.Add(MacroLabel);
            parent.Controls.Add(MacroTextBox);
            parent.Controls.Add(ApplicationLabel);
            parent.Controls.Add(ApplicationComboBox);
            parent.Controls.Add(RepeatCheckBox);
            parent.Controls.Add(RemoveButton);
        }
    }
}
