using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography;
using System.IO;

namespace PasswordEncryptionApplication
{
    /// <summary>
    /// Encrypt / Decrypt Class: 
    /// Based on article from http://www.superstarcoders.com
    /// </summary>
    class Cryption
    {
        /// <summary>
        /// Encryption method:
        /// Uses Symmetric Encryption.
        /// </summary>
        /// <typeparam name="T">Type of Encryption.</typeparam>
        /// <param name="toEncrypt">String to encrypt.</param>
        /// <param name="masterKey">The key used to encrypt.</param>
        /// <param name="salt">String to help encrypt.</param>
        /// <returns></returns>
        public static String Encrypt<T>(String toEncrypt, String masterKey, String salt)
            where T : SymmetricAlgorithm, new()
        {
            DeriveBytes dbytes = new Rfc2898DeriveBytes(masterKey, Encoding.Unicode.GetBytes(salt));
            SymmetricAlgorithm algorithm = new T();

            byte[] key = dbytes.GetBytes(algorithm.KeySize >> 3);
            byte[] IV = dbytes.GetBytes(algorithm.BlockSize >> 3);

            ICryptoTransform transform = algorithm.CreateEncryptor(key, IV);

            using (MemoryStream buffer = new MemoryStream())
            {
                using (CryptoStream stream = new CryptoStream(buffer, transform, CryptoStreamMode.Write))
                {
                    using (StreamWriter writer = new StreamWriter(stream, Encoding.Unicode))
                    {
                        writer.Write(toEncrypt);
                    }
                }

                return Convert.ToBase64String(buffer.ToArray());
            }
        }

        /// <summary>
        /// Decrypt method:
        /// Uses symmetric encryption.
        /// </summary>
        /// <typeparam name="T">Type of encryption.</typeparam>
        /// <param name="toDecrypt">String to decrypt.</param>
        /// <param name="masterKey">The key used to encrypt.</param>
        /// <param name="salt">String to help decrypt.</param>
        /// <returns></returns>
        public static String Decrypt<T>(String toDecrypt, String masterKey, String salt)
            where T : SymmetricAlgorithm, new()
        {
            DeriveBytes dbytes = new Rfc2898DeriveBytes(masterKey, Encoding.Unicode.GetBytes(salt));
            SymmetricAlgorithm algorithm = new T();

            byte[] key = dbytes.GetBytes(algorithm.KeySize >> 3);
            byte[] IV = dbytes.GetBytes(algorithm.BlockSize >> 3);

            ICryptoTransform transform = algorithm.CreateDecryptor(key, IV);

            using (MemoryStream buffer = new MemoryStream(Convert.FromBase64String(toDecrypt)))
            {
                using (CryptoStream stream = new CryptoStream(buffer, transform, CryptoStreamMode.Read))
                {
                    using (StreamReader reader = new StreamReader(stream, Encoding.Unicode))
                    {
                        return reader.ReadToEnd();
                    }
                }
            }
        }
    }
}