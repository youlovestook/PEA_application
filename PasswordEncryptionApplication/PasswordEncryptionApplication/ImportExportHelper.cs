using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Collections;

namespace PasswordEncryptionApplication.Model
{
    /// <summary>
    /// Reads and Writes Files.
    /// </summary>
    class ImportExportHelper
    {
        private String filename;

        /// <summary>
        /// Constructor. 
        /// </summary>
        /// <param name="filename">Name of the file to be imported/exported</param>
        public ImportExportHelper(String filename)
        {
            this.filename = filename;
        }


        /// <summary>
        /// Imports a file.
        /// </summary>
        /// <returns>String array with each line in the file.</returns>
        public String[] ImportFile()
        {
            if (File.Exists(filename))
            {
                String[] entries = File.ReadAllLines(filename);
                return entries;
            }
            else
            {
                return null;
            }

           
        }

        /// <summary>
        /// Exports the contents of the arraylist to the specified file.
        /// </summary>
        /// <param name="entries">The list of entries</param>
        public void ExportToFile(ArrayList entries)
        {
            String toWrite = "";

            if (File.Exists(filename))
            {
                foreach (Entry entry in entries)
                {
                    toWrite += entry.ToString();
                }

                File.WriteAllText(filename, toWrite);
            }
        }
    }
}
