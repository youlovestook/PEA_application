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
            Email = ConfigurationManager.AppSettings["Email"];
            MasterKey = ConfigurationManager.AppSettings["Master"];
        }

        public static void Save()
        {
            //Doesn't work!!
            ConfigurationManager.AppSettings.Set("Email", "Test");
            ConfigurationManager.AppSettings["Master"] = MasterKey;
        }
    }
}
