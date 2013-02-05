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

        public static void CreateEntries(String[] entries)
        {
            for (int i = 0; i < entries.Length; i++)
            {
                String[] splitEntries = entries[i].Split('\t');
                entryList.Add(new Entry(splitEntries[0], splitEntries[1], splitEntries[2]));
            }
        }

        public static void Add(Entry e)
        {
            entryList.Add(e);
        }

        public static void RemoveAt(int i)
        {
            entryList.RemoveAt(i);
        }

        public static int Count()
        {
            return entryList.Count;
        }

        public static ArrayList GetList()
        {
            return entryList;
        }


    }
}
