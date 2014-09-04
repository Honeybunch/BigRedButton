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
            this.StartStopButton = new System.Windows.Forms.Button();
            this.VIDTextBox = new System.Windows.Forms.TextBox();
            this.VIDLabel = new System.Windows.Forms.Label();
            this.PIDLabel = new System.Windows.Forms.Label();
            this.PIDTextBox = new System.Windows.Forms.TextBox();
            this.VIDResetButton = new System.Windows.Forms.Button();
            this.PIDResetButton = new System.Windows.Forms.Button();
            this.StatusLabel = new System.Windows.Forms.Label();
            this.AdvancedCheckBox = new System.Windows.Forms.CheckBox();
            this.CurrentStateTextBox = new System.Windows.Forms.TextBox();
            this.PressedStateTextBox = new System.Windows.Forms.TextBox();
            this.ReleasedStateTextBox = new System.Windows.Forms.TextBox();
            this.CurrentStateLabel = new System.Windows.Forms.Label();
            this.PressedStateLabel = new System.Windows.Forms.Label();
            this.ReleasedStateLabel = new System.Windows.Forms.Label();
            this.PollTimer = new System.Windows.Forms.Timer(this.components);
            this.MacrosPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.AddMacroButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // StartStopButton
            // 
            this.StartStopButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.StartStopButton.Location = new System.Drawing.Point(9, 327);
            this.StartStopButton.Name = "StartStopButton";
            this.StartStopButton.Size = new System.Drawing.Size(75, 23);
            this.StartStopButton.TabIndex = 0;
            this.StartStopButton.Text = "Start";
            this.StartStopButton.Click += new System.EventHandler(this.StartStopButton_Click);
            // 
            // VIDTextBox
            // 
            this.VIDTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.VIDTextBox.Location = new System.Drawing.Point(45, 22);
            this.VIDTextBox.Name = "VIDTextBox";
            this.VIDTextBox.Size = new System.Drawing.Size(510, 20);
            this.VIDTextBox.TabIndex = 1;
            this.VIDTextBox.Text = "1D34";
            this.VIDTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // VIDLabel
            // 
            this.VIDLabel.AutoSize = true;
            this.VIDLabel.Location = new System.Drawing.Point(9, 25);
            this.VIDLabel.Name = "VIDLabel";
            this.VIDLabel.Size = new System.Drawing.Size(25, 13);
            this.VIDLabel.TabIndex = 2;
            this.VIDLabel.Text = "VID";
            // 
            // PIDLabel
            // 
            this.PIDLabel.AutoSize = true;
            this.PIDLabel.Location = new System.Drawing.Point(9, 51);
            this.PIDLabel.Name = "PIDLabel";
            this.PIDLabel.Size = new System.Drawing.Size(25, 13);
            this.PIDLabel.TabIndex = 4;
            this.PIDLabel.Text = "PID";
            // 
            // PIDTextBox
            // 
            this.PIDTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PIDTextBox.Location = new System.Drawing.Point(45, 48);
            this.PIDTextBox.Name = "PIDTextBox";
            this.PIDTextBox.Size = new System.Drawing.Size(510, 20);
            this.PIDTextBox.TabIndex = 3;
            this.PIDTextBox.Text = "000D";
            this.PIDTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // VIDResetButton
            // 
            this.VIDResetButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.VIDResetButton.Location = new System.Drawing.Point(561, 20);
            this.VIDResetButton.Name = "VIDResetButton";
            this.VIDResetButton.Size = new System.Drawing.Size(75, 23);
            this.VIDResetButton.TabIndex = 5;
            this.VIDResetButton.Text = "Reset";
            this.VIDResetButton.Click += new System.EventHandler(this.VIDResetButton_Click);
            // 
            // PIDResetButton
            // 
            this.PIDResetButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PIDResetButton.Location = new System.Drawing.Point(561, 46);
            this.PIDResetButton.Name = "PIDResetButton";
            this.PIDResetButton.Size = new System.Drawing.Size(75, 23);
            this.PIDResetButton.TabIndex = 6;
            this.PIDResetButton.Text = "Reset";
            this.PIDResetButton.Click += new System.EventHandler(this.PIDResetButton_Click);
            // 
            // StatusLabel
            // 
            this.StatusLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.StatusLabel.AutoSize = true;
            this.StatusLabel.Location = new System.Drawing.Point(90, 332);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(60, 13);
            this.StatusLabel.TabIndex = 10;
            this.StatusLabel.Text = "Status: Idle";
            this.StatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AdvancedCheckBox
            // 
            this.AdvancedCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AdvancedCheckBox.AutoSize = true;
            this.AdvancedCheckBox.Location = new System.Drawing.Point(562, 86);
            this.AdvancedCheckBox.Name = "AdvancedCheckBox";
            this.AdvancedCheckBox.Size = new System.Drawing.Size(75, 17);
            this.AdvancedCheckBox.TabIndex = 11;
            this.AdvancedCheckBox.Text = "Advanced";
            this.AdvancedCheckBox.UseVisualStyleBackColor = true;
            this.AdvancedCheckBox.CheckedChanged += new System.EventHandler(this.AdvancedCheckBox_CheckedChanged);
            // 
            // CurrentStateTextBox
            // 
            this.CurrentStateTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CurrentStateTextBox.Location = new System.Drawing.Point(111, 112);
            this.CurrentStateTextBox.Name = "CurrentStateTextBox";
            this.CurrentStateTextBox.ReadOnly = true;
            this.CurrentStateTextBox.Size = new System.Drawing.Size(526, 20);
            this.CurrentStateTextBox.TabIndex = 12;
            this.CurrentStateTextBox.Text = "Unavailable";
            this.CurrentStateTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // PressedStateTextBox
            // 
            this.PressedStateTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PressedStateTextBox.Location = new System.Drawing.Point(111, 138);
            this.PressedStateTextBox.Name = "PressedStateTextBox";
            this.PressedStateTextBox.ReadOnly = true;
            this.PressedStateTextBox.Size = new System.Drawing.Size(526, 20);
            this.PressedStateTextBox.TabIndex = 13;
            this.PressedStateTextBox.Text = "0x16 0x00 0x00 0x00 0x00 0x00 0x00 0x03";
            this.PressedStateTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ReleasedStateTextBox
            // 
            this.ReleasedStateTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ReleasedStateTextBox.Location = new System.Drawing.Point(111, 164);
            this.ReleasedStateTextBox.Name = "ReleasedStateTextBox";
            this.ReleasedStateTextBox.ReadOnly = true;
            this.ReleasedStateTextBox.Size = new System.Drawing.Size(526, 20);
            this.ReleasedStateTextBox.TabIndex = 14;
            this.ReleasedStateTextBox.Text = "0x17 0x00 0x00 0x00 0x00 0x00 0x00 0x03";
            this.ReleasedStateTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // CurrentStateLabel
            // 
            this.CurrentStateLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CurrentStateLabel.AutoSize = true;
            this.CurrentStateLabel.Location = new System.Drawing.Point(9, 112);
            this.CurrentStateLabel.Name = "CurrentStateLabel";
            this.CurrentStateLabel.Size = new System.Drawing.Size(75, 13);
            this.CurrentStateLabel.TabIndex = 15;
            this.CurrentStateLabel.Text = "Current State: ";
            // 
            // PressedStateLabel
            // 
            this.PressedStateLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PressedStateLabel.AutoSize = true;
            this.PressedStateLabel.Location = new System.Drawing.Point(9, 138);
            this.PressedStateLabel.Name = "PressedStateLabel";
            this.PressedStateLabel.Size = new System.Drawing.Size(79, 13);
            this.PressedStateLabel.TabIndex = 16;
            this.PressedStateLabel.Text = "Pressed State: ";
            // 
            // ReleasedStateLabel
            // 
            this.ReleasedStateLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ReleasedStateLabel.AutoSize = true;
            this.ReleasedStateLabel.Location = new System.Drawing.Point(9, 164);
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
            // MacrosPanel
            // 
            this.MacrosPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MacrosPanel.AutoScroll = true;
            this.MacrosPanel.Location = new System.Drawing.Point(12, 190);
            this.MacrosPanel.Name = "MacrosPanel";
            this.MacrosPanel.Size = new System.Drawing.Size(625, 131);
            this.MacrosPanel.TabIndex = 21;
            // 
            // AddMacroButton
            // 
            this.AddMacroButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.AddMacroButton.Location = new System.Drawing.Point(562, 327);
            this.AddMacroButton.Name = "AddMacroButton";
            this.AddMacroButton.Size = new System.Drawing.Size(75, 23);
            this.AddMacroButton.TabIndex = 22;
            this.AddMacroButton.Text = "Add Macro";
            this.AddMacroButton.Click += new System.EventHandler(this.AddMacroButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 357);
            this.Controls.Add(this.AddMacroButton);
            this.Controls.Add(this.MacrosPanel);
            this.Controls.Add(this.ReleasedStateLabel);
            this.Controls.Add(this.PressedStateLabel);
            this.Controls.Add(this.CurrentStateLabel);
            this.Controls.Add(this.ReleasedStateTextBox);
            this.Controls.Add(this.PressedStateTextBox);
            this.Controls.Add(this.CurrentStateTextBox);
            this.Controls.Add(this.AdvancedCheckBox);
            this.Controls.Add(this.StatusLabel);
            this.Controls.Add(this.PIDResetButton);
            this.Controls.Add(this.VIDResetButton);
            this.Controls.Add(this.PIDLabel);
            this.Controls.Add(this.PIDTextBox);
            this.Controls.Add(this.StartStopButton);
            this.Controls.Add(this.VIDLabel);
            this.Controls.Add(this.VIDTextBox);
            this.Name = "MainForm";
            this.Text = "Big Red Button";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button StartStopButton;
        private System.Windows.Forms.TextBox VIDTextBox;
        private System.Windows.Forms.Label VIDLabel;
        private System.Windows.Forms.Label PIDLabel;
        private System.Windows.Forms.TextBox PIDTextBox;
        private System.Windows.Forms.Button VIDResetButton;
        private System.Windows.Forms.Button PIDResetButton;
        private System.Windows.Forms.Label StatusLabel;
        private System.Windows.Forms.CheckBox AdvancedCheckBox;
        private System.Windows.Forms.TextBox CurrentStateTextBox;
        private System.Windows.Forms.TextBox PressedStateTextBox;
        private System.Windows.Forms.TextBox ReleasedStateTextBox;
        private System.Windows.Forms.Label CurrentStateLabel;
        private System.Windows.Forms.Label PressedStateLabel;
        private System.Windows.Forms.Label ReleasedStateLabel;
        private System.Windows.Forms.Timer PollTimer;
        private System.Windows.Forms.FlowLayoutPanel MacrosPanel;
        private System.Windows.Forms.Button AddMacroButton;
    }
}

