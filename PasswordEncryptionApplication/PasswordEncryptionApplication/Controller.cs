using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Security.Cryptography;
using PasswordEncryptionApplication.View;
using PasswordEncryptionApplication.Model;

namespace PasswordEncryptionApplication.Controller
{
    class Controller
    {
        public bool PasswordIsValidated { set; get; }

        /// <summary>
        /// Specifies what the Application does on start.
        /// </summary>
        public void Start(ListView lView)
        {
            //OpenForm("MainForm");
            PasswordIsValidated = false;
            ConfigManager.Load();
            ImportEntries();
            DisplayEntries(lView);
        }

        /// <summary>
        /// Specifies what the Application does on close.
        /// </summary>
        public void Close()
        {
            ImportExportHelper impExpHelper = new ImportExportHelper("pf.txt");
            impExpHelper.ExportToFile(EntryFactory.GetList());
            ConfigManager.Save();
        }

        /// <summary>
        /// Tells the ViewManager to open the specified form.
        /// </summary>
        /// <param name="formName">Name of the form. Case Sensitive.</param>
        public void OpenForm(String formName)
        {
            ViewManager.addThread(formName);
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

        /// <summary>
        /// Encrypts the user selected row.
        /// </summary>
        /// <param name="lView">ListView Item.</param>
        /// <param name="masterKey">The master key.</param>
        public void EncryptRow(ListView lView, String masterKey)
        {

            String domain =  lView.SelectedItems[0].SubItems[0].Text;
            String username = lView.SelectedItems[0].SubItems[1].Text; 
            String password = lView.SelectedItems[0].SubItems[2].Text; 
                             
            
            String[] row = {
                            Cryption.Encrypt<AesManaged>(domain, masterKey, "salt"),
                            Cryption.Encrypt<AesManaged>(username, masterKey, "salt"),
                            Cryption.Encrypt<AesManaged>(password, masterKey, "salt")
                           };

            Entry temp = EntryFactory.CreateTempEntry(row);
            lView.SelectedItems[0].SubItems[0].Text = temp.Domain;
            lView.SelectedItems[0].SubItems[1].Text = temp.Username;
            lView.SelectedItems[0].SubItems[2].Text = temp.Password;
        }


        /// <summary>
        /// Decrypts the selected row
        /// </summary>
        /// <param name="lView">ListView item</param>
        /// <param name="masterKey">The masterkey</param>
        public void DecryptRow(ListView lView, String masterKey)
        {
            if (PasswordIsValidated)
            {
                String domain = lView.SelectedItems[0].SubItems[0].Text;
                String username = lView.SelectedItems[0].SubItems[1].Text;
                String password = lView.SelectedItems[0].SubItems[2].Text;

                String[] row = {
                            Cryption.Decrypt<AesManaged>(domain, masterKey, "salt"),
                            Cryption.Decrypt<AesManaged>(username, masterKey, "salt"),
                            Cryption.Decrypt<AesManaged>(password, masterKey, "salt")
                           };

                Entry temp = EntryFactory.CreateTempEntry(row);
                lView.SelectedItems[0].SubItems[0].Text = temp.Domain;
                lView.SelectedItems[0].SubItems[1].Text = temp.Username;
                lView.SelectedItems[0].SubItems[2].Text = temp.Password;
            }
        }

        public Boolean CheckMasterKey(String masterKey)
        {
            return (masterKey == ConfigManager.MasterKey);
        }

        /// <summary>
        /// Add an entry. Should be called from the AddForm.
        /// </summary>
        /// <param name="e">The entry to add.</param>
        public void AddEntry(Entry e)
        {
            EntryFactory.Add(e);
        }
    

    }
}
