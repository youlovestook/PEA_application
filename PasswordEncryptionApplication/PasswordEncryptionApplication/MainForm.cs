﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Collections;

namespace PasswordEncryptionApplication.View
{
    public partial class MainForm : Form
    {
        Controller controller = new Controller();
        
        public MainForm()
        {
            InitializeComponent();
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
            controller.EncryptRow(domainListView, "Test");
        }

        private void masterKeyEnterBtn_Click(object sender, EventArgs e)
        {
            //TODO: Finish...
            controller.CheckMasterKey(masterKeyTextBox.Text).ToString();
        }

    }
}
