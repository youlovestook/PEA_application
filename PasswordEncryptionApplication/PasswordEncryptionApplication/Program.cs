using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using PasswordEncryptionApplication.View;
using PasswordEncryptionApplication.Controller;

namespace PasswordEncryptionApplication
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Controller.Controller controller = new Controller.Controller();
            controller.Start();
        }
    }
}
