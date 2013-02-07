using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace PasswordEncryptionApplication
{
    class Controller
    {
        /// <summary>
        /// Opens the specified Form
        /// </summary>
        /// <param name="formName">Name of the form. Case Sensitive.</param>
        public void OpenForm(String formName)
        {
            FormThreads.addThread(formName);
        }

        /// <summary>
        /// Import the entries from the save file into Entry objects.
        /// </summary>
        public void ImportEntries()
        {
            ImportExportHelper impExpHelper = new ImportExportHelper("pf.txt");
            EntryFactory.CreateEntries(impExpHelper.ImportFile());
        }

        /// <summary>
        /// Print the Entries to the List View.
        /// </summary>
        /// <param name="lView">The list view</param>
        public void DisplayEntries(ListView lView)
        {
            foreach (Entry entry in EntryFactory.GetList())
            {
                lView.Items.Add(new ListViewItem(new string[] 
                {
                    entry.Domain, entry.Username, entry.Password
                }));
            }           
        }


    }
}
