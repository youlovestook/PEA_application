using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace PasswordEncryptionApplication
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        #region Utility Methods
        
        /// <summary>
        /// Opens the AddEditForm
        /// </summary>
        public static void OpenAddEditForm()
        {
            Application.Run(new AddEditForm());
        }

        #endregion

        // Event Handlers

        private void addBtn_Click(object sender, EventArgs e)
        {
            Thread addForm = new Thread(new ThreadStart(OpenAddEditForm));
            addForm.Start();
        }

    }
}
