namespace Windows69Login
{
    partial class theWindow
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
            this.theMessage = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.usernameBox = new System.Windows.Forms.TextBox();
            this.passwordBox = new System.Windows.Forms.TextBox();
            this.okButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.theKeys = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.theKeys)).BeginInit();
            this.SuspendLayout();
            // 
            // theMessage
            // 
            this.theMessage.AutoSize = true;
            this.helpProvider1.SetHelpString(this.theMessage, "Why would you click this?");
            this.theMessage.Location = new System.Drawing.Point(98, 14);
            this.theMessage.Name = "theMessage";
            this.helpProvider1.SetShowHelp(this.theMessage, true);
            this.theMessage.Size = new System.Drawing.Size(267, 13);
            this.theMessage.TabIndex = 0;
            this.theMessage.Text = "Type a user name and password to log on to Windows.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.helpProvider1.SetHelpString(this.label2, "That\'s your name, by the way.");
            this.label2.Location = new System.Drawing.Point(97, 58);
            this.label2.Name = "label2";
            this.helpProvider1.SetShowHelp(this.label2, true);
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "User name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.helpProvider1.SetHelpString(this.label3, "\"Oh, my username was username, and my password was password, and I lost a million" +
        " dollars!\"");
            this.label3.Location = new System.Drawing.Point(97, 85);
            this.label3.Name = "label3";
            this.helpProvider1.SetShowHelp(this.label3, true);
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Password:";
            // 
            // usernameBox
            // 
            this.usernameBox.BackColor = System.Drawing.Color.White;
            this.helpProvider1.SetHelpString(this.usernameBox, "Type your user name in here. The user name is the name of the user. Which is you." +
        " I hope.");
            this.usernameBox.Location = new System.Drawing.Point(161, 54);
            this.usernameBox.Name = "usernameBox";
            this.helpProvider1.SetShowHelp(this.usernameBox, true);
            this.usernameBox.Size = new System.Drawing.Size(127, 20);
            this.usernameBox.TabIndex = 3;
            // 
            // passwordBox
            // 
            this.passwordBox.BackColor = System.Drawing.Color.White;
            this.helpProvider1.SetHelpString(this.passwordBox, "Type your password here. If you have no password, then just click OK. It\'ll work," +
        " I promise!");
            this.passwordBox.Location = new System.Drawing.Point(161, 82);
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.PasswordChar = '•';
            this.helpProvider1.SetShowHelp(this.passwordBox, true);
            this.passwordBox.Size = new System.Drawing.Size(127, 20);
            this.passwordBox.TabIndex = 4;
            // 
            // okButton
            // 
            this.helpProvider1.SetHelpString(this.okButton, "Click this when you want to log in.");
            this.okButton.Location = new System.Drawing.Point(372, 14);
            this.okButton.Name = "okButton";
            this.helpProvider1.SetShowHelp(this.okButton, true);
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 5;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.pressedOK);
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.helpProvider1.SetHelpString(this.cancelButton, "Click this if you don\'t want to log in anymore.");
            this.cancelButton.Location = new System.Drawing.Point(372, 43);
            this.cancelButton.Name = "cancelButton";
            this.helpProvider1.SetShowHelp(this.cancelButton, true);
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 6;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.pressedCancel);
            // 
            // theKeys
            // 
            this.theKeys.Image = global::Windows69Login.Properties.Resources.windowskeyhaha;
            this.theKeys.Location = new System.Drawing.Point(27, 12);
            this.theKeys.Name = "theKeys";
            this.helpProvider1.SetShowHelp(this.theKeys, false);
            this.theKeys.Size = new System.Drawing.Size(46, 51);
            this.theKeys.TabIndex = 7;
            this.theKeys.TabStop = false;
            this.theKeys.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.theKeys_HelpRequested);
            // 
            // theWindow
            // 
            this.AcceptButton = this.okButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(459, 119);
            this.Controls.Add(this.theKeys);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.passwordBox);
            this.Controls.Add(this.usernameBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.theMessage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.HelpButton = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "theWindow";
            this.Text = "Welcome to Windows";
            ((System.ComponentModel.ISupportInitialize)(this.theKeys)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label theMessage;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox usernameBox;
        private System.Windows.Forms.TextBox passwordBox;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.HelpProvider helpProvider1;
        private System.Windows.Forms.PictureBox theKeys;
    }
}

