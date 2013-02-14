using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;

namespace PasswordEncryptionApplication.Model
{
    class ConfigManager
    {
        public static String Email { get; set; }
        public static String MasterKey { get; set; }

        public static void Load()
        {
            //TODO: Try to replace with Configuration manager
            Email = ConfigurationSettings.AppSettings["Email"];
            MasterKey = ConfigurationSettings.AppSettings["Master"];
        }
    }
}
