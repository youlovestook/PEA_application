﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;

namespace PasswordEncryptionApplication.Model
{
    class ConfigManager
    {
        private bool isFirstRun;
        public static String Email { get; set; }
        public static String MasterKey { get; set; }

        public static void Load()
        {
            Email = ConfigurationManager.AppSettings["Email"];
            MasterKey = ConfigurationManager.AppSettings["Master"];
        }

        public static void Save()
        {
            //Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            //config.ConnectionStrings.ConnectionStrings["Email"].ConnectionString = "Test";
            //config.ConnectionStrings.ConnectionStrings["Master"].ConnectionString = MasterKey;
            //config.Save();
            //return;
        }
    }
}
