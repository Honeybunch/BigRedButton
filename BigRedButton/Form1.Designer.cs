namespace BigRedButton
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.StartButton = new System.Windows.Forms.Button();
            this.VIDTextBox = new System.Windows.Forms.TextBox();
            this.VIDLabel = new System.Windows.Forms.Label();
            this.PIDLabel = new System.Windows.Forms.Label();
            this.PIDTextBox = new System.Windows.Forms.TextBox();
            this.VIDResetButton = new System.Windows.Forms.Button();
            this.PIDResetButton = new System.Windows.Forms.Button();
            this.MacroLabel = new System.Windows.Forms.Label();
            this.MacroTextBox = new System.Windows.Forms.TextBox();
            this.StopButton = new System.Windows.Forms.Button();
            this.StatusLabel = new System.Windows.Forms.Label();
            this.AdvancedCheckBox = new System.Windows.Forms.CheckBox();
            this.CurrentStateTextBox = new System.Windows.Forms.TextBox();
            this.PressedStateTextBox = new System.Windows.Forms.TextBox();
            this.ReleasedStateTextBox = new System.Windows.Forms.TextBox();
            this.CurrentStateLabel = new System.Windows.Forms.Label();
            this.PressedStateLabel = new System.Windows.Forms.Label();
            this.ReleasedStateLabel = new System.Windows.Forms.Label();
            this.PollTimer = new System.Windows.Forms.Timer(this.components);
            this.ProcessesLabel = new System.Windows.Forms.Label();
            this.ProcessesComboBox = new System.Windows.Forms.ComboBox();
            this.ApplicationTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // StartButton
            // 
            this.StartButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.StartButton.Location = new System.Drawing.Point(392, 248);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(75, 23);
            this.StartButton.TabIndex = 0;
            this.StartButton.Text = "Start";
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // VIDTextBox
            // 
            this.VIDTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.VIDTextBox.Location = new System.Drawing.Point(45, 21);
            this.VIDTextBox.Name = "VIDTextBox";
            this.VIDTextBox.Size = new System.Drawing.Size(340, 20);
            this.VIDTextBox.TabIndex = 1;
            this.VIDTextBox.Text = "1D34";
            this.VIDTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // VIDLabel
            // 
            this.VIDLabel.AutoSize = true;
            this.VIDLabel.Location = new System.Drawing.Point(14, 24);
            this.VIDLabel.Name = "VIDLabel";
            this.VIDLabel.Size = new System.Drawing.Size(25, 13);
            this.VIDLabel.TabIndex = 2;
            this.VIDLabel.Text = "VID";
            // 
            // PIDLabel
            // 
            this.PIDLabel.AutoSize = true;
            this.PIDLabel.Location = new System.Drawing.Point(14, 50);
            this.PIDLabel.Name = "PIDLabel";
            this.PIDLabel.Size = new System.Drawing.Size(25, 13);
            this.PIDLabel.TabIndex = 4;
            this.PIDLabel.Text = "PID";
            // 
            // PIDTextBox
            // 
            this.PIDTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PIDTextBox.Location = new System.Drawing.Point(45, 47);
            this.PIDTextBox.Name = "PIDTextBox";
            this.PIDTextBox.Size = new System.Drawing.Size(340, 20);
            this.PIDTextBox.TabIndex = 3;
            this.PIDTextBox.Text = "000D";
            this.PIDTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // VIDResetButton
            // 
            this.VIDResetButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.VIDResetButton.Location = new System.Drawing.Point(391, 19);
            this.VIDResetButton.Name = "VIDResetButton";
            this.VIDResetButton.Size = new System.Drawing.Size(75, 23);
            this.VIDResetButton.TabIndex = 5;
            this.VIDResetButton.Text = "Reset";
            this.VIDResetButton.Click += new System.EventHandler(this.VIDResetButton_Click);
            // 
            // PIDResetButton
            // 
            this.PIDResetButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PIDResetButton.Location = new System.Drawing.Point(391, 45);
            this.PIDResetButton.Name = "PIDResetButton";
            this.PIDResetButton.Size = new System.Drawing.Size(75, 23);
            this.PIDResetButton.TabIndex = 6;
            this.PIDResetButton.Text = "Reset";
            this.PIDResetButton.Click += new System.EventHandler(this.PIDResetButton_Click);
            // 
            // MacroLabel
            // 
            this.MacroLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.MacroLabel.AutoSize = true;
            this.MacroLabel.Location = new System.Drawing.Point(14, 215);
            this.MacroLabel.Name = "MacroLabel";
            this.MacroLabel.Size = new System.Drawing.Size(37, 13);
            this.MacroLabel.TabIndex = 8;
            this.MacroLabel.Text = "Macro";
            // 
            // MacroTextBox
            // 
            this.MacroTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.MacroTextBox.Location = new System.Drawing.Point(67, 212);
            this.MacroTextBox.Name = "MacroTextBox";
            this.MacroTextBox.Size = new System.Drawing.Size(121, 20);
            this.MacroTextBox.TabIndex = 7;
            this.MacroTextBox.Text = "A";
            this.MacroTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // StopButton
            // 
            this.StopButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.StopButton.Location = new System.Drawing.Point(12, 248);
            this.StopButton.Name = "StopButton";
            this.StopButton.Size = new System.Drawing.Size(75, 23);
            this.StopButton.TabIndex = 9;
            this.StopButton.Text = "Stop";
            this.StopButton.Click += new System.EventHandler(this.StopButton_Click);
            // 
            // StatusLabel
            // 
            this.StatusLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.StatusLabel.AutoSize = true;
            this.StatusLabel.Location = new System.Drawing.Point(108, 253);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(60, 13);
            this.StatusLabel.TabIndex = 10;
            this.StatusLabel.Text = "Status: Idle";
            this.StatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AdvancedCheckBox
            // 
            this.AdvancedCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.AdvancedCheckBox.AutoSize = true;
            this.AdvancedCheckBox.Location = new System.Drawing.Point(392, 92);
            this.AdvancedCheckBox.Name = "AdvancedCheckBox";
            this.AdvancedCheckBox.Size = new System.Drawing.Size(75, 17);
            this.AdvancedCheckBox.TabIndex = 11;
            this.AdvancedCheckBox.Text = "Advanced";
            this.AdvancedCheckBox.UseVisualStyleBackColor = true;
            this.AdvancedCheckBox.CheckedChanged += new System.EventHandler(this.AdvancedCheckBox_CheckedChanged);
            // 
            // CurrentStateTextBox
            // 
            this.CurrentStateTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CurrentStateTextBox.Location = new System.Drawing.Point(111, 118);
            this.CurrentStateTextBox.Name = "CurrentStateTextBox";
            this.CurrentStateTextBox.ReadOnly = true;
            this.CurrentStateTextBox.Size = new System.Drawing.Size(356, 20);
            this.CurrentStateTextBox.TabIndex = 12;
            this.CurrentStateTextBox.Text = "Unavailable";
            this.CurrentStateTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // PressedStateTextBox
            // 
            this.PressedStateTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PressedStateTextBox.Location = new System.Drawing.Point(111, 144);
            this.PressedStateTextBox.Name = "PressedStateTextBox";
            this.PressedStateTextBox.ReadOnly = true;
            this.PressedStateTextBox.Size = new System.Drawing.Size(356, 20);
            this.PressedStateTextBox.TabIndex = 13;
            this.PressedStateTextBox.Text = "0x16 0x00 0x00 0x00 0x00 0x00 0x00 0x03";
            this.PressedStateTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ReleasedStateTextBox
            // 
            this.ReleasedStateTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ReleasedStateTextBox.Location = new System.Drawing.Point(111, 170);
            this.ReleasedStateTextBox.Name = "ReleasedStateTextBox";
            this.ReleasedStateTextBox.ReadOnly = true;
            this.ReleasedStateTextBox.Size = new System.Drawing.Size(356, 20);
            this.ReleasedStateTextBox.TabIndex = 14;
            this.ReleasedStateTextBox.Text = "0x17 0x00 0x00 0x00 0x00 0x00 0x00 0x03";
            this.ReleasedStateTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // CurrentStateLabel
            // 
            this.CurrentStateLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CurrentStateLabel.AutoSize = true;
            this.CurrentStateLabel.Location = new System.Drawing.Point(12, 118);
            this.CurrentStateLabel.Name = "CurrentStateLabel";
            this.CurrentStateLabel.Size = new System.Drawing.Size(75, 13);
            this.CurrentStateLabel.TabIndex = 15;
            this.CurrentStateLabel.Text = "Current State: ";
            // 
            // PressedStateLabel
            // 
            this.PressedStateLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PressedStateLabel.AutoSize = true;
            this.PressedStateLabel.Location = new System.Drawing.Point(12, 144);
            this.PressedStateLabel.Name = "PressedStateLabel";
            this.PressedStateLabel.Size = new System.Drawing.Size(79, 13);
            this.PressedStateLabel.TabIndex = 16;
            this.PressedStateLabel.Text = "Pressed State: ";
            // 
            // ReleasedStateLabel
            // 
            this.ReleasedStateLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ReleasedStateLabel.AutoSize = true;
            this.ReleasedStateLabel.Location = new System.Drawing.Point(12, 170);
            this.ReleasedStateLabel.Name = "ReleasedStateLabel";
            this.ReleasedStateLabel.Size = new System.Drawing.Size(83, 13);
            this.ReleasedStateLabel.TabIndex = 17;
            this.ReleasedStateLabel.Text = "Released State:";
            // 
            // PollTimer
            // 
            this.PollTimer.Interval = 10;
            this.PollTimer.Tick += new System.EventHandler(this.ButtonPoll);
            // 
            // ProcessesLabel
            // 
            this.ProcessesLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ProcessesLabel.AutoSize = true;
            this.ProcessesLabel.Location = new System.Drawing.Point(194, 215);
            this.ProcessesLabel.Name = "ProcessesLabel";
            this.ProcessesLabel.Size = new System.Drawing.Size(59, 13);
            this.ProcessesLabel.TabIndex = 19;
            this.ProcessesLabel.Text = "Application";
            // 
            // ProcessesComboBox
            // 
            this.ProcessesComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ProcessesComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ProcessesComboBox.ItemHeight = 13;
            this.ProcessesComboBox.Location = new System.Drawing.Point(259, 212);
            this.ProcessesComboBox.Name = "ProcessesComboBox";
            this.ProcessesComboBox.Size = new System.Drawing.Size(208, 21);
            this.ProcessesComboBox.TabIndex = 18;
            // 
            // ApplicationTimer
            // 
            this.ApplicationTimer.Enabled = true;
            this.ApplicationTimer.Interval = 1000;
            this.ApplicationTimer.Tick += new System.EventHandler(this.ApplicationTimer_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 283);
            this.Controls.Add(this.ProcessesLabel);
            this.Controls.Add(this.ProcessesComboBox);
            this.Controls.Add(this.ReleasedStateLabel);
            this.Controls.Add(this.PressedStateLabel);
            this.Controls.Add(this.CurrentStateLabel);
            this.Controls.Add(this.ReleasedStateTextBox);
            this.Controls.Add(this.PressedStateTextBox);
            this.Controls.Add(this.CurrentStateTextBox);
            this.Controls.Add(this.AdvancedCheckBox);
            this.Controls.Add(this.StatusLabel);
            this.Controls.Add(this.StopButton);
            this.Controls.Add(this.MacroLabel);
            this.Controls.Add(this.MacroTextBox);
            this.Controls.Add(this.PIDResetButton);
            this.Controls.Add(this.VIDResetButton);
            this.Controls.Add(this.PIDLabel);
            this.Controls.Add(this.PIDTextBox);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.VIDLabel);
            this.Controls.Add(this.VIDTextBox);
            this.Name = "MainForm";
            this.Text = "Big Red Button";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.TextBox VIDTextBox;
        private System.Windows.Forms.Label VIDLabel;
        private System.Windows.Forms.Label PIDLabel;
        private System.Windows.Forms.TextBox PIDTextBox;
        private System.Windows.Forms.Button VIDResetButton;
        private System.Windows.Forms.Button PIDResetButton;
        private System.Windows.Forms.Label MacroLabel;
        private System.Windows.Forms.TextBox MacroTextBox;
        private System.Windows.Forms.Button StopButton;
        private System.Windows.Forms.Label StatusLabel;
        private System.Windows.Forms.CheckBox AdvancedCheckBox;
        private System.Windows.Forms.TextBox CurrentStateTextBox;
        private System.Windows.Forms.TextBox PressedStateTextBox;
        private System.Windows.Forms.TextBox ReleasedStateTextBox;
        private System.Windows.Forms.Label CurrentStateLabel;
        private System.Windows.Forms.Label PressedStateLabel;
        private System.Windows.Forms.Label ReleasedStateLabel;
        private System.Windows.Forms.Timer PollTimer;
        private System.Windows.Forms.Label ProcessesLabel;
        private System.Windows.Forms.ComboBox ProcessesComboBox;
        private System.Windows.Forms.Timer ApplicationTimer;
    }
}

