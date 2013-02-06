using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace PasswordEncryptionApplication
{
    class FormThreads
    {
        public static void addThread(string threadName)
        {
            //Threads t = new Threads();
            switch (threadName)
            {
                case "AddForm":
                    Thread addForm = new Thread(new ThreadStart(OpenAddForm));
                    addForm.Start();
                    break;
                case "EditForm":
                    Thread editForm = new Thread(new ThreadStart(OpenEditForm));
                    editForm.Start();
                    break;
                default:
                    throw new Exception(threadName + " not supported.");
            }
        }
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
    }
}
