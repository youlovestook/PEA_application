namespace PasswordEncryptionApplication
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.domainTab = new System.Windows.Forms.TabPage();
            this.noteTab = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.masterKeyEnterBtn = new System.Windows.Forms.Button();
            this.masterKeyTextBox = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.searchBtn = new System.Windows.Forms.Button();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.addBtn = new System.Windows.Forms.Button();
            this.editBtn = new System.Windows.Forms.Button();
            this.removeBtn = new System.Windows.Forms.Button();
            this.changeMasterKeyBtn = new System.Windows.Forms.Button();
            this.domainListBox = new System.Windows.Forms.ListBox();
            this.tabControl1.SuspendLayout();
            this.domainTab.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.domainTab);
            this.tabControl1.Controls.Add(this.noteTab);
            this.tabControl1.Location = new System.Drawing.Point(16, 65);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(464, 332);
            this.tabControl1.TabIndex = 0;
            // 
            // domainTab
            // 
            this.domainTab.Controls.Add(this.domainListBox);
            this.domainTab.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.domainTab.Location = new System.Drawing.Point(4, 22);
            this.domainTab.Name = "domainTab";
            this.domainTab.Padding = new System.Windows.Forms.Padding(3);
            this.domainTab.Size = new System.Drawing.Size(456, 306);
            this.domainTab.TabIndex = 0;
            this.domainTab.Text = "Domains";
            this.domainTab.UseVisualStyleBackColor = true;
            // 
            // noteTab
            // 
            this.noteTab.Location = new System.Drawing.Point(4, 22);
            this.noteTab.Name = "noteTab";
            this.noteTab.Padding = new System.Windows.Forms.Padding(3);
            this.noteTab.Size = new System.Drawing.Size(456, 306);
            this.noteTab.TabIndex = 1;
            this.noteTab.Text = "Notes";
            this.noteTab.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.masterKeyEnterBtn);
            this.groupBox1.Controls.Add(this.masterKeyTextBox);
            this.groupBox1.Location = new System.Drawing.Point(16, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(219, 46);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Master Key:";
            // 
            // masterKeyEnterBtn
            // 
            this.masterKeyEnterBtn.Location = new System.Drawing.Point(169, 18);
            this.masterKeyEnterBtn.Name = "masterKeyEnterBtn";
            this.masterKeyEnterBtn.Size = new System.Drawing.Size(43, 23);
            this.masterKeyEnterBtn.TabIndex = 1;
            this.masterKeyEnterBtn.Text = "Enter";
            this.masterKeyEnterBtn.UseVisualStyleBackColor = true;
            // 
            // masterKeyTextBox
            // 
            this.masterKeyTextBox.Location = new System.Drawing.Point(7, 20);
            this.masterKeyTextBox.Name = "masterKeyTextBox";
            this.masterKeyTextBox.Size = new System.Drawing.Size(156, 20);
            this.masterKeyTextBox.TabIndex = 0;
            this.masterKeyTextBox.UseSystemPasswordChar = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.searchBtn);
            this.groupBox2.Controls.Add(this.searchTextBox);
            this.groupBox2.Location = new System.Drawing.Point(252, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(228, 46);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Domain Search:";
            // 
            // searchBtn
            // 
            this.searchBtn.Location = new System.Drawing.Point(181, 18);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(36, 23);
            this.searchBtn.TabIndex = 1;
            this.searchBtn.Text = "Go";
            this.searchBtn.UseVisualStyleBackColor = true;
            // 
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(7, 20);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(167, 20);
            this.searchTextBox.TabIndex = 0;
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(16, 403);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(75, 23);
            this.addBtn.TabIndex = 3;
            this.addBtn.Text = "Add";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // editBtn
            // 
            this.editBtn.Enabled = false;
            this.editBtn.Location = new System.Drawing.Point(97, 403);
            this.editBtn.Name = "editBtn";
            this.editBtn.Size = new System.Drawing.Size(75, 23);
            this.editBtn.TabIndex = 3;
            this.editBtn.Text = "Edit";
            this.editBtn.UseVisualStyleBackColor = true;
            // 
            // removeBtn
            // 
            this.removeBtn.Enabled = false;
            this.removeBtn.Location = new System.Drawing.Point(178, 403);
            this.removeBtn.Name = "removeBtn";
            this.removeBtn.Size = new System.Drawing.Size(75, 23);
            this.removeBtn.TabIndex = 3;
            this.removeBtn.Text = "Remove";
            this.removeBtn.UseVisualStyleBackColor = true;
            // 
            // changeMasterKeyBtn
            // 
            this.changeMasterKeyBtn.Location = new System.Drawing.Point(364, 403);
            this.changeMasterKeyBtn.Name = "changeMasterKeyBtn";
            this.changeMasterKeyBtn.Size = new System.Drawing.Size(116, 23);
            this.changeMasterKeyBtn.TabIndex = 4;
            this.changeMasterKeyBtn.Text = "Change Master Key";
            this.changeMasterKeyBtn.UseVisualStyleBackColor = true;
            // 
            // domainListBox
            // 
            this.domainListBox.FormattingEnabled = true;
            this.domainListBox.Location = new System.Drawing.Point(0, 0);
            this.domainListBox.MultiColumn = true;
            this.domainListBox.Name = "domainListBox";
            this.domainListBox.Size = new System.Drawing.Size(456, 303);
            this.domainListBox.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 438);
            this.Controls.Add(this.changeMasterKeyBtn);
            this.Controls.Add(this.removeBtn);
            this.Controls.Add(this.editBtn);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tabControl1);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.domainTab.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage noteTab;
        private System.Windows.Forms.TabPage domainTab;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button masterKeyEnterBtn;
        private System.Windows.Forms.TextBox masterKeyTextBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button editBtn;
        private System.Windows.Forms.Button removeBtn;
        private System.Windows.Forms.Button changeMasterKeyBtn;
        private System.Windows.Forms.ListBox domainListBox;
    }
}

