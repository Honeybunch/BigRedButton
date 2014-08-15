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
            this.StartButton = new MetroFramework.Controls.MetroButton();
            this.VIDTextBox = new MetroFramework.Controls.MetroTextBox();
            this.VIDLabel = new MetroFramework.Controls.MetroLabel();
            this.PIDLabel = new MetroFramework.Controls.MetroLabel();
            this.PIDTextBox = new MetroFramework.Controls.MetroTextBox();
            this.VIDResetButton = new MetroFramework.Controls.MetroButton();
            this.PIDResetButton = new MetroFramework.Controls.MetroButton();
            this.MacroLabel = new MetroFramework.Controls.MetroLabel();
            this.MacroTextBox = new MetroFramework.Controls.MetroTextBox();
            this.StopButton = new MetroFramework.Controls.MetroButton();
            this.StatusLabel = new MetroFramework.Controls.MetroLabel();
            this.AdvancedCheckBox = new MetroFramework.Controls.MetroCheckBox();
            this.CurrentStateTextBox = new MetroFramework.Controls.MetroTextBox();
            this.PressedStateTextBox = new MetroFramework.Controls.MetroTextBox();
            this.ReleasedStateTextBox = new MetroFramework.Controls.MetroTextBox();
            this.CurrentStateLabel = new MetroFramework.Controls.MetroLabel();
            this.PressedStateLabel = new MetroFramework.Controls.MetroLabel();
            this.ReleasedStateLabel = new MetroFramework.Controls.MetroLabel();
            this.PollTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // StartButton
            // 
            this.StartButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.StartButton.Highlight = false;
            this.StartButton.Location = new System.Drawing.Point(358, 318);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(75, 23);
            this.StartButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.StartButton.StyleManager = null;
            this.StartButton.TabIndex = 0;
            this.StartButton.Text = "Apply";
            this.StartButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.StartButton.Click += new System.EventHandler(this.ApplyButton_Click);
            // 
            // VIDTextBox
            // 
            this.VIDTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.VIDTextBox.CustomBackground = false;
            this.VIDTextBox.CustomForeColor = false;
            this.VIDTextBox.FontSize = MetroFramework.MetroTextBoxSize.Small;
            this.VIDTextBox.FontWeight = MetroFramework.MetroTextBoxWeight.Regular;
            this.VIDTextBox.Location = new System.Drawing.Point(46, 94);
            this.VIDTextBox.Multiline = false;
            this.VIDTextBox.Name = "VIDTextBox";
            this.VIDTextBox.SelectedText = "";
            this.VIDTextBox.Size = new System.Drawing.Size(306, 20);
            this.VIDTextBox.Style = MetroFramework.MetroColorStyle.Blue;
            this.VIDTextBox.StyleManager = null;
            this.VIDTextBox.TabIndex = 1;
            this.VIDTextBox.Text = "1D34";
            this.VIDTextBox.Theme = MetroFramework.MetroThemeStyle.Light;
            this.VIDTextBox.UseStyleColors = false;
            // 
            // VIDLabel
            // 
            this.VIDLabel.AutoSize = true;
            this.VIDLabel.CustomBackground = false;
            this.VIDLabel.CustomForeColor = false;
            this.VIDLabel.FontSize = MetroFramework.MetroLabelSize.Medium;
            this.VIDLabel.FontWeight = MetroFramework.MetroLabelWeight.Light;
            this.VIDLabel.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.VIDLabel.Location = new System.Drawing.Point(15, 94);
            this.VIDLabel.Name = "VIDLabel";
            this.VIDLabel.Size = new System.Drawing.Size(29, 19);
            this.VIDLabel.Style = MetroFramework.MetroColorStyle.Blue;
            this.VIDLabel.StyleManager = null;
            this.VIDLabel.TabIndex = 2;
            this.VIDLabel.Text = "VID";
            this.VIDLabel.Theme = MetroFramework.MetroThemeStyle.Light;
            this.VIDLabel.UseStyleColors = false;
            // 
            // PIDLabel
            // 
            this.PIDLabel.AutoSize = true;
            this.PIDLabel.CustomBackground = false;
            this.PIDLabel.CustomForeColor = false;
            this.PIDLabel.FontSize = MetroFramework.MetroLabelSize.Medium;
            this.PIDLabel.FontWeight = MetroFramework.MetroLabelWeight.Light;
            this.PIDLabel.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.PIDLabel.Location = new System.Drawing.Point(15, 120);
            this.PIDLabel.Name = "PIDLabel";
            this.PIDLabel.Size = new System.Drawing.Size(29, 19);
            this.PIDLabel.Style = MetroFramework.MetroColorStyle.Blue;
            this.PIDLabel.StyleManager = null;
            this.PIDLabel.TabIndex = 4;
            this.PIDLabel.Text = "PID";
            this.PIDLabel.Theme = MetroFramework.MetroThemeStyle.Light;
            this.PIDLabel.UseStyleColors = false;
            // 
            // PIDTextBox
            // 
            this.PIDTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PIDTextBox.CustomBackground = false;
            this.PIDTextBox.CustomForeColor = false;
            this.PIDTextBox.FontSize = MetroFramework.MetroTextBoxSize.Small;
            this.PIDTextBox.FontWeight = MetroFramework.MetroTextBoxWeight.Regular;
            this.PIDTextBox.Location = new System.Drawing.Point(46, 120);
            this.PIDTextBox.Multiline = false;
            this.PIDTextBox.Name = "PIDTextBox";
            this.PIDTextBox.SelectedText = "";
            this.PIDTextBox.Size = new System.Drawing.Size(306, 20);
            this.PIDTextBox.Style = MetroFramework.MetroColorStyle.Blue;
            this.PIDTextBox.StyleManager = null;
            this.PIDTextBox.TabIndex = 3;
            this.PIDTextBox.Text = "000D";
            this.PIDTextBox.Theme = MetroFramework.MetroThemeStyle.Light;
            this.PIDTextBox.UseStyleColors = false;
            // 
            // VIDResetButton
            // 
            this.VIDResetButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.VIDResetButton.Highlight = false;
            this.VIDResetButton.Location = new System.Drawing.Point(358, 92);
            this.VIDResetButton.Name = "VIDResetButton";
            this.VIDResetButton.Size = new System.Drawing.Size(75, 23);
            this.VIDResetButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.VIDResetButton.StyleManager = null;
            this.VIDResetButton.TabIndex = 5;
            this.VIDResetButton.Text = "Reset";
            this.VIDResetButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.VIDResetButton.Click += new System.EventHandler(this.VIDResetButton_Click);
            // 
            // PIDResetButton
            // 
            this.PIDResetButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PIDResetButton.Highlight = false;
            this.PIDResetButton.Location = new System.Drawing.Point(358, 118);
            this.PIDResetButton.Name = "PIDResetButton";
            this.PIDResetButton.Size = new System.Drawing.Size(75, 23);
            this.PIDResetButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.PIDResetButton.StyleManager = null;
            this.PIDResetButton.TabIndex = 6;
            this.PIDResetButton.Text = "Reset";
            this.PIDResetButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.PIDResetButton.Click += new System.EventHandler(this.PIDResetButton_Click);
            // 
            // MacroLabel
            // 
            this.MacroLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.MacroLabel.AutoSize = true;
            this.MacroLabel.CustomBackground = false;
            this.MacroLabel.CustomForeColor = false;
            this.MacroLabel.FontSize = MetroFramework.MetroLabelSize.Medium;
            this.MacroLabel.FontWeight = MetroFramework.MetroLabelWeight.Light;
            this.MacroLabel.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.MacroLabel.Location = new System.Drawing.Point(15, 292);
            this.MacroLabel.Name = "MacroLabel";
            this.MacroLabel.Size = new System.Drawing.Size(47, 19);
            this.MacroLabel.Style = MetroFramework.MetroColorStyle.Blue;
            this.MacroLabel.StyleManager = null;
            this.MacroLabel.TabIndex = 8;
            this.MacroLabel.Text = "Macro";
            this.MacroLabel.Theme = MetroFramework.MetroThemeStyle.Light;
            this.MacroLabel.UseStyleColors = false;
            // 
            // MacroTextBox
            // 
            this.MacroTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MacroTextBox.CustomBackground = false;
            this.MacroTextBox.CustomForeColor = false;
            this.MacroTextBox.FontSize = MetroFramework.MetroTextBoxSize.Small;
            this.MacroTextBox.FontWeight = MetroFramework.MetroTextBoxWeight.Regular;
            this.MacroTextBox.Location = new System.Drawing.Point(68, 292);
            this.MacroTextBox.Multiline = false;
            this.MacroTextBox.Name = "MacroTextBox";
            this.MacroTextBox.SelectedText = "";
            this.MacroTextBox.Size = new System.Drawing.Size(365, 20);
            this.MacroTextBox.Style = MetroFramework.MetroColorStyle.Blue;
            this.MacroTextBox.StyleManager = null;
            this.MacroTextBox.TabIndex = 7;
            this.MacroTextBox.Text = "A";
            this.MacroTextBox.Theme = MetroFramework.MetroThemeStyle.Light;
            this.MacroTextBox.UseStyleColors = false;
            // 
            // StopButton
            // 
            this.StopButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.StopButton.Highlight = false;
            this.StopButton.Location = new System.Drawing.Point(12, 318);
            this.StopButton.Name = "StopButton";
            this.StopButton.Size = new System.Drawing.Size(75, 23);
            this.StopButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.StopButton.StyleManager = null;
            this.StopButton.TabIndex = 9;
            this.StopButton.Text = "Stop";
            this.StopButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.StopButton.Click += new System.EventHandler(this.StopButton_Click);
            // 
            // StatusLabel
            // 
            this.StatusLabel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.StatusLabel.AutoSize = true;
            this.StatusLabel.CustomBackground = false;
            this.StatusLabel.CustomForeColor = false;
            this.StatusLabel.FontSize = MetroFramework.MetroLabelSize.Medium;
            this.StatusLabel.FontWeight = MetroFramework.MetroLabelWeight.Light;
            this.StatusLabel.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.StatusLabel.Location = new System.Drawing.Point(185, 323);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(71, 19);
            this.StatusLabel.Style = MetroFramework.MetroColorStyle.Blue;
            this.StatusLabel.StyleManager = null;
            this.StatusLabel.TabIndex = 10;
            this.StatusLabel.Text = "Status: Idle";
            this.StatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.StatusLabel.Theme = MetroFramework.MetroThemeStyle.Light;
            this.StatusLabel.UseStyleColors = false;
            // 
            // AdvancedCheckBox
            // 
            this.AdvancedCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.AdvancedCheckBox.AutoSize = true;
            this.AdvancedCheckBox.CustomBackground = false;
            this.AdvancedCheckBox.CustomForeColor = false;
            this.AdvancedCheckBox.FontSize = MetroFramework.MetroLinkSize.Small;
            this.AdvancedCheckBox.FontWeight = MetroFramework.MetroLinkWeight.Regular;
            this.AdvancedCheckBox.Location = new System.Drawing.Point(357, 164);
            this.AdvancedCheckBox.Name = "AdvancedCheckBox";
            this.AdvancedCheckBox.Size = new System.Drawing.Size(76, 15);
            this.AdvancedCheckBox.Style = MetroFramework.MetroColorStyle.Blue;
            this.AdvancedCheckBox.StyleManager = null;
            this.AdvancedCheckBox.TabIndex = 11;
            this.AdvancedCheckBox.Text = "Advanced";
            this.AdvancedCheckBox.Theme = MetroFramework.MetroThemeStyle.Light;
            this.AdvancedCheckBox.UseStyleColors = false;
            this.AdvancedCheckBox.UseVisualStyleBackColor = true;
            this.AdvancedCheckBox.CheckedChanged += new System.EventHandler(this.AdvancedCheckBox_CheckedChanged);
            // 
            // CurrentStateTextBox
            // 
            this.CurrentStateTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CurrentStateTextBox.CustomBackground = false;
            this.CurrentStateTextBox.CustomForeColor = false;
            this.CurrentStateTextBox.FontSize = MetroFramework.MetroTextBoxSize.Small;
            this.CurrentStateTextBox.FontWeight = MetroFramework.MetroTextBoxWeight.Regular;
            this.CurrentStateTextBox.Location = new System.Drawing.Point(111, 188);
            this.CurrentStateTextBox.Multiline = false;
            this.CurrentStateTextBox.Name = "CurrentStateTextBox";
            this.CurrentStateTextBox.SelectedText = "";
            this.CurrentStateTextBox.Size = new System.Drawing.Size(322, 20);
            this.CurrentStateTextBox.Style = MetroFramework.MetroColorStyle.Blue;
            this.CurrentStateTextBox.StyleManager = null;
            this.CurrentStateTextBox.TabIndex = 12;
            this.CurrentStateTextBox.Text = "Unavailable";
            this.CurrentStateTextBox.Theme = MetroFramework.MetroThemeStyle.Light;
            this.CurrentStateTextBox.UseStyleColors = false;
            // 
            // PressedStateTextBox
            // 
            this.PressedStateTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PressedStateTextBox.CustomBackground = false;
            this.PressedStateTextBox.CustomForeColor = false;
            this.PressedStateTextBox.FontSize = MetroFramework.MetroTextBoxSize.Small;
            this.PressedStateTextBox.FontWeight = MetroFramework.MetroTextBoxWeight.Regular;
            this.PressedStateTextBox.Location = new System.Drawing.Point(111, 214);
            this.PressedStateTextBox.Multiline = false;
            this.PressedStateTextBox.Name = "PressedStateTextBox";
            this.PressedStateTextBox.SelectedText = "";
            this.PressedStateTextBox.Size = new System.Drawing.Size(322, 20);
            this.PressedStateTextBox.Style = MetroFramework.MetroColorStyle.Blue;
            this.PressedStateTextBox.StyleManager = null;
            this.PressedStateTextBox.TabIndex = 13;
            this.PressedStateTextBox.Text = "0x16 0x00 0x00 0x00 0x00 0x00 0x00 0x03";
            this.PressedStateTextBox.Theme = MetroFramework.MetroThemeStyle.Light;
            this.PressedStateTextBox.UseStyleColors = false;
            // 
            // ReleasedStateTextBox
            // 
            this.ReleasedStateTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ReleasedStateTextBox.CustomBackground = false;
            this.ReleasedStateTextBox.CustomForeColor = false;
            this.ReleasedStateTextBox.FontSize = MetroFramework.MetroTextBoxSize.Small;
            this.ReleasedStateTextBox.FontWeight = MetroFramework.MetroTextBoxWeight.Regular;
            this.ReleasedStateTextBox.Location = new System.Drawing.Point(111, 240);
            this.ReleasedStateTextBox.Multiline = false;
            this.ReleasedStateTextBox.Name = "ReleasedStateTextBox";
            this.ReleasedStateTextBox.SelectedText = "";
            this.ReleasedStateTextBox.Size = new System.Drawing.Size(322, 20);
            this.ReleasedStateTextBox.Style = MetroFramework.MetroColorStyle.Blue;
            this.ReleasedStateTextBox.StyleManager = null;
            this.ReleasedStateTextBox.TabIndex = 14;
            this.ReleasedStateTextBox.Text = "0x17 0x00 0x00 0x00 0x00 0x00 0x00 0x03";
            this.ReleasedStateTextBox.Theme = MetroFramework.MetroThemeStyle.Light;
            this.ReleasedStateTextBox.UseStyleColors = false;
            // 
            // CurrentStateLabel
            // 
            this.CurrentStateLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CurrentStateLabel.AutoSize = true;
            this.CurrentStateLabel.CustomBackground = false;
            this.CurrentStateLabel.CustomForeColor = false;
            this.CurrentStateLabel.FontSize = MetroFramework.MetroLabelSize.Medium;
            this.CurrentStateLabel.FontWeight = MetroFramework.MetroLabelWeight.Light;
            this.CurrentStateLabel.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.CurrentStateLabel.Location = new System.Drawing.Point(12, 188);
            this.CurrentStateLabel.Name = "CurrentStateLabel";
            this.CurrentStateLabel.Size = new System.Drawing.Size(93, 19);
            this.CurrentStateLabel.Style = MetroFramework.MetroColorStyle.Blue;
            this.CurrentStateLabel.StyleManager = null;
            this.CurrentStateLabel.TabIndex = 15;
            this.CurrentStateLabel.Text = "Current State: ";
            this.CurrentStateLabel.Theme = MetroFramework.MetroThemeStyle.Light;
            this.CurrentStateLabel.UseStyleColors = false;
            // 
            // PressedStateLabel
            // 
            this.PressedStateLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PressedStateLabel.AutoSize = true;
            this.PressedStateLabel.CustomBackground = false;
            this.PressedStateLabel.CustomForeColor = false;
            this.PressedStateLabel.FontSize = MetroFramework.MetroLabelSize.Medium;
            this.PressedStateLabel.FontWeight = MetroFramework.MetroLabelWeight.Light;
            this.PressedStateLabel.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.PressedStateLabel.Location = new System.Drawing.Point(12, 214);
            this.PressedStateLabel.Name = "PressedStateLabel";
            this.PressedStateLabel.Size = new System.Drawing.Size(94, 19);
            this.PressedStateLabel.Style = MetroFramework.MetroColorStyle.Blue;
            this.PressedStateLabel.StyleManager = null;
            this.PressedStateLabel.TabIndex = 16;
            this.PressedStateLabel.Text = "Pressed State: ";
            this.PressedStateLabel.Theme = MetroFramework.MetroThemeStyle.Light;
            this.PressedStateLabel.UseStyleColors = false;
            // 
            // ReleasedStateLabel
            // 
            this.ReleasedStateLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ReleasedStateLabel.AutoSize = true;
            this.ReleasedStateLabel.CustomBackground = false;
            this.ReleasedStateLabel.CustomForeColor = false;
            this.ReleasedStateLabel.FontSize = MetroFramework.MetroLabelSize.Medium;
            this.ReleasedStateLabel.FontWeight = MetroFramework.MetroLabelWeight.Light;
            this.ReleasedStateLabel.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.ReleasedStateLabel.Location = new System.Drawing.Point(12, 240);
            this.ReleasedStateLabel.Name = "ReleasedStateLabel";
            this.ReleasedStateLabel.Size = new System.Drawing.Size(97, 19);
            this.ReleasedStateLabel.Style = MetroFramework.MetroColorStyle.Blue;
            this.ReleasedStateLabel.StyleManager = null;
            this.ReleasedStateLabel.TabIndex = 17;
            this.ReleasedStateLabel.Text = "Released State:";
            this.ReleasedStateLabel.Theme = MetroFramework.MetroThemeStyle.Light;
            this.ReleasedStateLabel.UseStyleColors = false;
            // 
            // PollTimer
            // 
            this.PollTimer.Interval = 10;
            this.PollTimer.Tick += new System.EventHandler(this.ButtonPoll);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 353);
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
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "MainForm";
            this.Text = "Big Red Button";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton StartButton;
        private MetroFramework.Controls.MetroTextBox VIDTextBox;
        private MetroFramework.Controls.MetroLabel VIDLabel;
        private MetroFramework.Controls.MetroLabel PIDLabel;
        private MetroFramework.Controls.MetroTextBox PIDTextBox;
        private MetroFramework.Controls.MetroButton VIDResetButton;
        private MetroFramework.Controls.MetroButton PIDResetButton;
        private MetroFramework.Controls.MetroLabel MacroLabel;
        private MetroFramework.Controls.MetroTextBox MacroTextBox;
        private MetroFramework.Controls.MetroButton StopButton;
        private MetroFramework.Controls.MetroLabel StatusLabel;
        private MetroFramework.Controls.MetroCheckBox AdvancedCheckBox;
        private MetroFramework.Controls.MetroTextBox CurrentStateTextBox;
        private MetroFramework.Controls.MetroTextBox PressedStateTextBox;
        private MetroFramework.Controls.MetroTextBox ReleasedStateTextBox;
        private MetroFramework.Controls.MetroLabel CurrentStateLabel;
        private MetroFramework.Controls.MetroLabel PressedStateLabel;
        private MetroFramework.Controls.MetroLabel ReleasedStateLabel;
        private System.Windows.Forms.Timer PollTimer;
    }
}

