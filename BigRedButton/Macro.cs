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
        /*
         * Singleton
         */

        /// <summary>
        /// A Singleton list of all macros
        /// </summary>
        public static List<Macro> Macros;

        /// <summary>
        /// A Singleton list of all applications installed on the system 
        /// </summary>
        public static List<string> Applications;

        /*
        * Member
        */

        //The index; for displaying the proper label
        public int index = -1;

        //The Controls
        public Panel MacroPanel;
        public Label MacroLabel;
        public TextBox MacroTextBox;
        public Label ApplicationLabel;
        public ComboBox ApplicationComboBox;
        public CheckBox RepeatCheckBox;
        public Button RemoveButton;

        public Macro() 
        {
            if (Macros == null)
                Macros = new List<Macro>();
        }

        public void CreateControls(Control parent) 
        {
            //If the index has not been set from outside, then we're adding a new one from scratch
            if(index == -1)
                index = Macros.Count;

            //Create controls
            MacroPanel = new Panel();
            MacroLabel = new Label();
            MacroTextBox = new TextBox();
            ApplicationLabel = new Label();
            ApplicationComboBox = new ComboBox();
            RepeatCheckBox = new CheckBox();
            RemoveButton = new Button();

            //
            // MacroPanel
            //
            this.MacroPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MacroPanel.Width = parent.ClientSize.Width;
            this.MacroPanel.Height = 25;
            parent.ClientSizeChanged += delegate(object o, EventArgs e)
                {this.MacroPanel.Width = parent.ClientSize.Width;};
            // 
            // MacroLabel
            // 
            this.MacroLabel.AutoSize = true;
            this.MacroLabel.Location = new System.Drawing.Point(0, 6);
            this.MacroLabel.Name = "MacroLabel" + index;
            this.MacroLabel.Size = new System.Drawing.Size(49, 13);
            this.MacroLabel.TabIndex = 8;
            this.MacroLabel.Text = "Macro " + (index+1) + ":";
            // 
            // MacroTextBox
            // 
            this.MacroTextBox.Location = new System.Drawing.Point(58, 3);
            this.MacroTextBox.Name = "MacroTextBox" + index;
            this.MacroTextBox.Size = new System.Drawing.Size(40, 20);
            this.MacroTextBox.TabIndex = 7;
            this.MacroTextBox.Text = "";
            this.MacroTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ApplicationLabel
            // 
            this.ApplicationLabel.AutoSize = true;
            this.ApplicationLabel.Location = new System.Drawing.Point(104, 6);
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
            this.ApplicationComboBox.Location = new System.Drawing.Point(169, 3);
            this.ApplicationComboBox.Name = "ApplicationComboBox" + index;
            this.ApplicationComboBox.Size = new System.Drawing.Size(parent.ClientSize.Width - 355, 21);
            this.ApplicationComboBox.TabIndex = 18;
            // 
            // RepeatCheckBox
            // 
            this.RepeatCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.RepeatCheckBox.AutoSize = true;
            this.RepeatCheckBox.Location = new System.Drawing.Point(parent.ClientSize.Width - 180, 5);
            this.RepeatCheckBox.Name = "RepeatCheckBox" + index;
            this.RepeatCheckBox.Size = new System.Drawing.Size(101, 17);
            this.RepeatCheckBox.TabIndex = 22;
            this.RepeatCheckBox.Text = "Repeat on Hold";
            this.RepeatCheckBox.UseVisualStyleBackColor = true;
            // 
            // RemoveMacroButton
            // 
            this.RemoveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.RemoveButton.Location = new System.Drawing.Point(parent.ClientSize.Width - 69, 1);
            this.RemoveButton.Name = "RemoveMacroButton" + index;
            this.RemoveButton.Size = new System.Drawing.Size(63, 23);
            this.RemoveButton.TabIndex = 23;
            this.RemoveButton.Text = "Remove";
            this.RemoveButton.Click += RemoveMacro;

            //Add applications to the Applications ComboBox
            foreach(string s in Applications)
                ApplicationComboBox.Items.Add(s);

            //Set the current item in the combo box to be the first item; "None"
            this.ApplicationComboBox.SelectedItem = ApplicationComboBox.Items[0];

            //Add this macro to the macro list
            Macros.Add(this);

            //
            //Add controls to the Macro Panel
            //
            MacroPanel.Controls.Add(MacroLabel);
            MacroPanel.Controls.Add(MacroTextBox);
            MacroPanel.Controls.Add(ApplicationLabel);
            MacroPanel.Controls.Add(ApplicationComboBox);
            MacroPanel.Controls.Add(RepeatCheckBox);
            MacroPanel.Controls.Add(RemoveButton);

            //Add the Macro Panel to the parent
            parent.Controls.Add(MacroPanel);
        }

        //This will delete the macro from the list and move all other macros to their new positions
        private void RemoveMacro(object o, EventArgs e) 
        {
            Control parent = MacroPanel.Parent;

            for (int i = index; i < Macros.Count; i++)
            {
                Macro m = Macros[i];

                m.index--;

                m.MacroLabel.Text = "Macro " + (m.index + 1) + ":";
            }

            //Remove the controls from the parent
            parent.Controls.Remove(MacroPanel);

            //Remove the macro from the macro's list
            Macros.Remove(this);
        }
    }
}
