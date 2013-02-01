using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PasswordEncryptionApplication
{
    class Cryption
    {
        private String masterKey;


        public void setMasterKey(String newKey)
        {
            masterKey = newKey;
        }

        /// <summary>
        /// Super weak encryption routine to test other functionality.
        /// </summary>
        /// <param name="toEncrypt">String to encrypt</param>
        /// <returns>Encrypted String</returns>
        public String Encrypt(String toEncrypt)
        {
            char[] encrypt = toEncrypt.ToCharArray();

            for (int i = 0; i < encrypt.Length; i++)
            {
                encrypt[i] = (char)((int)encrypt[i] * 2);
            }

            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append(encrypt);
            return strBuilder.ToString();
        }

        /// <summary>
        /// Decrypt a String
        /// </summary>
        /// <param name="toDecrypt">String to be decrypted.</param>
        /// <returns>Decrypted String</returns>
        public String Decrypt(String toDecrypt, String masterKey)
        {
            if (masterKey.Equals(this.masterKey))
            {
                char[] decrypt = toDecrypt.ToCharArray();

                for (int i = 0; i < decrypt.Length; i++)
                {
                    decrypt[i] = (char)((int)decrypt[i] / 2);
                }

                StringBuilder strBuilder = new StringBuilder();
                strBuilder.Append(decrypt);
                return strBuilder.ToString();

            }
            else
            {
                return "Wrong key";
            }
        }
    }
}
