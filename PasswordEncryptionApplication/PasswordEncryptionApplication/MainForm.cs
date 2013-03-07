using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Collections;
using PasswordEncryptionApplication.Controller;

namespace PasswordEncryptionApplication.View
{
    public partial class MainForm : Form
    {
        Controller.Controller controller = new Controller.Controller();
        
        public MainForm()
        {
            InitializeComponent();
            controller.DisplayEntries(domainListView);
        }

        // Event Handlers

        private void addBtn_Click(object sender, EventArgs e)
        {
            controller.OpenForm("AddForm");
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            controller.OpenForm("EditForm");
        }

        private void domainListView_ItemActivate(object sender, EventArgs e)
        {
            controller.DecryptRow(domainListView, "Test");
        }

        private void masterKeyEnterBtn_Click(object sender, EventArgs e)
        {
            if (controller.CheckMasterKey(masterKeyTextBox.Text))
            {
                masterKeyTextBox.Text = "";
                controller.PasswordIsValidated = true;
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            controller.Close();
        }

        private void changeMasterKeyBtn_Click(object sender, EventArgs e)
        {
            controller.OpenForm("SettingsForm");
        }

    }
}
