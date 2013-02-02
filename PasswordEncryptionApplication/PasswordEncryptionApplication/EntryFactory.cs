using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace PasswordEncryptionApplication
{
    class EntryFactory
    {
        private static ArrayList entryList = new ArrayList();

        public static ArrayList CreateEntries(String[] entries)
        {
            for (int i = 0; i < entries.Length; i++)
            {
                String[] splitEntries = entries[i].Split('\t');
                entryList.Add(new Entry(splitEntries[0], splitEntries[1], splitEntries[2]));
            }

            return entryList;
        }
    }
}
