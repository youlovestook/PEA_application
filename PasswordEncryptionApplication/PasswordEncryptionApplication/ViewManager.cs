using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace PasswordEncryptionApplication.View
{
    class ViewManager
    {
        /// <summary>
        /// Adds a new thread. If new Form is added, Add the thread here.
        /// </summary>
        /// <param name="threadName">The name of the Form.</param>
        public static void addThread(string threadName)
        {
            switch (threadName)
            {
                case "MainForm":
                    Thread mainForm = new Thread(new ThreadStart(openMainForm));
                    mainForm.Start();
                    break;
                case "AddForm":
                    Thread addForm = new Thread(new ThreadStart(openAddForm));
                    addForm.Start();
                    break;
                case "EditForm":
                    Thread editForm = new Thread(new ThreadStart(openEditForm));
                    editForm.Start();
                    break;
                case "SettingsForm":
                    Thread settingsForm = new Thread(new ThreadStart(openSettingsForm));
                    settingsForm.Start();
                    break;
                default:
                    throw new Exception(threadName + " not supported.");
            }
        }

        private static void openMainForm()
        {
            Application.Run(new MainForm());
        }

        /// <summary>
        /// Opens the AddForm
        /// </summary>
        private static void openAddForm()
        {
            Application.Run(new AddForm());
        }

        /// <summary>
        /// Opens the EditForm
        /// </summary>
        private static void openEditForm()
        {
            Application.Run(new EditForm());
        }

        private static void openSettingsForm()
        {
            Application.Run(new SettingsForm());
        }
    }
}
