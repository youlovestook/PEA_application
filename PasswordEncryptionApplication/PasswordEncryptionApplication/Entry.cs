using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PasswordEncryptionApplication
{
    class Entry
    {
        public String Domain { get; set; }
        public String Username { get; set; }
        public String Password { get; set; }

        public Entry(String domain, String username, String password)
        {
            this.Domain = domain;
            this.Username = username;
            this.Password = password;
        }

        public override String ToString()
        {
            return Domain + "\t" + Username + "\t" + Password + "\n";
        }
    }
}
