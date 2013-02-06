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
        Controller controller = new Controller();
        
        public MainForm()
        {
            InitializeComponent();
            printLabels();
        }

        #region Utility Methods
        
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
            controller.OpenForm("AddForm");
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            controller.OpenForm("EditForm");
        }

        private void domainListView_ItemActivate(object sender, EventArgs e)
        {
            MessageBox.Show("");
        }

    }
}
