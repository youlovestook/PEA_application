namespace PasswordEncryptionApplication
{
    partial class SettingsForm
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
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.confirmEmailBox = new System.Windows.Forms.TextBox();
            this.masterPasswordBox = new System.Windows.Forms.TextBox();
            this.changePasswordBox = new System.Windows.Forms.TextBox();
            this.confirmChangePasswordBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.saveSettingsBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(134, 12);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(100, 20);
            this.emailTextBox.TabIndex = 0;
            // 
            // confirmEmailBox
            // 
            this.confirmEmailBox.Location = new System.Drawing.Point(134, 38);
            this.confirmEmailBox.Name = "confirmEmailBox";
            this.confirmEmailBox.Size = new System.Drawing.Size(100, 20);
            this.confirmEmailBox.TabIndex = 1;
            // 
            // masterPasswordBox
            // 
            this.masterPasswordBox.Location = new System.Drawing.Point(259, 142);
            this.masterPasswordBox.Name = "masterPasswordBox";
            this.masterPasswordBox.Size = new System.Drawing.Size(100, 20);
            this.masterPasswordBox.TabIndex = 2;
            this.masterPasswordBox.UseSystemPasswordChar = true;
            // 
            // changePasswordBox
            // 
            this.changePasswordBox.Location = new System.Drawing.Point(134, 64);
            this.changePasswordBox.Name = "changePasswordBox";
            this.changePasswordBox.Size = new System.Drawing.Size(100, 20);
            this.changePasswordBox.TabIndex = 2;
            this.changePasswordBox.UseSystemPasswordChar = true;
            // 
            // confirmChangePasswordBox
            // 
            this.confirmChangePasswordBox.Location = new System.Drawing.Point(134, 90);
            this.confirmChangePasswordBox.Name = "confirmChangePasswordBox";
            this.confirmChangePasswordBox.Size = new System.Drawing.Size(100, 20);
            this.confirmChangePasswordBox.TabIndex = 2;
            this.confirmChangePasswordBox.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Recovery Email";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Confirm Email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Change Password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(46, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Confirm Change";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(165, 145);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Master Password";
            // 
            // saveSettingsBtn
            // 
            this.saveSettingsBtn.Location = new System.Drawing.Point(365, 140);
            this.saveSettingsBtn.Name = "saveSettingsBtn";
            this.saveSettingsBtn.Size = new System.Drawing.Size(41, 23);
            this.saveSettingsBtn.TabIndex = 8;
            this.saveSettingsBtn.Text = "Save";
            this.saveSettingsBtn.UseVisualStyleBackColor = true;
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 174);
            this.Controls.Add(this.saveSettingsBtn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.confirmChangePasswordBox);
            this.Controls.Add(this.changePasswordBox);
            this.Controls.Add(this.masterPasswordBox);
            this.Controls.Add(this.confirmEmailBox);
            this.Controls.Add(this.emailTextBox);
            this.Name = "SettingsForm";
            this.Text = "SettingsForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox confirmEmailBox;
        private System.Windows.Forms.TextBox masterPasswordBox;
        private System.Windows.Forms.TextBox changePasswordBox;
        private System.Windows.Forms.TextBox confirmChangePasswordBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button saveSettingsBtn;
    }
}