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

namespace PasswordEncryptionApplication
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            printLabels();
        }

        #region Utility Methods
        
        /// <summary>
        /// Opens the AddEditForm
        /// </summary>
        public static void OpenAddEditForm()
        {
            Application.Run(new AddEditForm());
        }

        /// <summary>
        /// Print the entries to the Domain List View
        /// </summary>
        private void printLabels()
        {
            ImportExportHelper impExpHelper = new ImportExportHelper("pf.txt");
            ArrayList entries = EntryFactory.CreateEntries(impExpHelper.ImportFile());
            
            foreach (Entry entry in entries)
            {
                this.domainListView.Items.Add(new ListViewItem(new string[] 
                {
                    entry.Domain, entry.Username, entry.Password
                }));
            }

            
        }

        #endregion

        // Event Handlers

        private void addBtn_Click(object sender, EventArgs e)
        {
            Thread addForm = new Thread(new ThreadStart(OpenAddEditForm));
            addForm.Start();
        }

        private void domainListView_ItemActivate(object sender, EventArgs e)
        {
            MessageBox.Show("ItemClicked");
        }
    }
}
