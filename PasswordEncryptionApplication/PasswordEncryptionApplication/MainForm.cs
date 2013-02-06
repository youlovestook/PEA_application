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
        /// Opens the AddForm
        /// </summary>
        public static void OpenAddForm()
        {
            Application.Run(new AddForm());
        }

        /// <summary>
        /// Opens the EditForm
        /// </summary>
        public static void OpenEditForm()
        {
            Application.Run(new EditForm());
        }

        /// <summary>
        /// Print the entries to the Domain List View
        /// </summary>
        private void printLabels()
        {
            ImportExportHelper impExpHelper = new ImportExportHelper("pf.txt");
            EntryFactory.CreateEntries(impExpHelper.ImportFile());
            
            foreach (Entry entry in EntryFactory.GetList())
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
            Thread addForm = new Thread(new ThreadStart(OpenAddForm));
            addForm.Start();
        }

        private void domainListView_ItemActivate(object sender, EventArgs e)
        {
            MessageBox.Show("");
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            Thread editForm = new Thread(new ThreadStart(OpenEditForm));
            editForm.Start();
        }
    }
}
