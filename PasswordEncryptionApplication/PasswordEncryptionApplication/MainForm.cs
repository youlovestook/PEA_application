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
using PasswordEncryptionApplication.Model;

namespace PasswordEncryptionApplication.View
{
    public partial class MainForm : Form
    {
        Controller.Controller controller = new Controller.Controller();
        
        public MainForm()
        {
            InitializeComponent();
            //EntryFactory.Add(new Entry("Amazon", "phil.m", "bestPassword"));
            //EntryFactory.Add(new Entry("Amazone", "phil.l", "least"));
            //EntryFactory.Add(new Entry("Amazones", "phil.n", "worst"));
            //EntryFactory.Add(new Entry("Amazonest", "phil.o", "bestP"));
            controller.ImportEntries();
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
