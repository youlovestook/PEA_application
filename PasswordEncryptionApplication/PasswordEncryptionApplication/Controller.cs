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
        public void OpenForm(String formName)
        {
            FormThreads.addThread(formName);
        }


    }
}
