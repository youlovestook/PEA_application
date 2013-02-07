using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace PasswordEncryptionApplication
{
    /// <summary>
    /// Creates and Holds Entry objects.
    /// </summary>
    class EntryFactory
    {
        private static ArrayList entryList = new ArrayList();

        /// <summary>
        /// Reads the entries from the String and creates Entry objects.
        /// </summary>
        /// <param name="entries">String of entries to be made into objects.</param>
        public static void CreateEntries(String[] entries)
        {
            for (int i = 0; i < entries.Length; i++)
            {
                String[] splitEntries = entries[i].Split('\t');
                entryList.Add(new Entry(splitEntries[0], splitEntries[1], splitEntries[2]));
            }
        }

        /// <summary>
        /// Add to the list.
        /// </summary>
        /// <param name="e">Entry object</param>
        public static void Add(Entry e)
        {
            entryList.Add(e);
        }

        /// <summary>
        /// Remove from the list at index.
        /// </summary>
        /// <param name="i">The index.</param>
        public static void RemoveAt(int i)
        {
            entryList.RemoveAt(i);
        }

        /// <summary>
        /// Number of elements in the list.
        /// </summary>
        /// <returns>int Number of list elements.</returns>
        public static int Count()
        {
            return entryList.Count;
        }

        /// <summary>
        /// Get the List.
        /// </summary>
        /// <returns>The entire ArrayList.</returns>
        public static ArrayList GetList()
        {
            return entryList;
        }


    }
}
