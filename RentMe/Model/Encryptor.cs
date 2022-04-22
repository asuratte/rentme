using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace RentMe.Model
{
    /// <summary>
    /// Provides encryption functionality for the RentMe application
    /// </summary>
    public class Encryptor
    {
        private static readonly string key = "5u8x/A?D(G+KbPeShVmYq3s6v9y$B&E)";

        /// <summary>
        /// Encrypts a given string.
        /// </summary>
        /// <param name="stringToEncrypt">The string to encrypt.</param>
        /// <returns>Encrypted string</returns>
        public static string EncryptString(string stringToEncrypt)
        {
            if (stringToEncrypt == null || stringToEncrypt == "")
            {
                throw new ArgumentNullException("String to encrypt must not be null or empty");
            }

            byte[] iv = new byte[16];
            byte[] encryptedStringAsBytes;

            using (Aes aes = Aes.Create())
            {
                aes.Key = Encoding.UTF8.GetBytes(key);
                aes.IV = iv;

                ICryptoTransform theEncryptor = aes.CreateEncryptor(aes.Key, aes.IV);

                using (MemoryStream theMemoryStream = new MemoryStream())
                {
                    using (CryptoStream theCryptoStream = new CryptoStream((Stream)theMemoryStream, theEncryptor, CryptoStreamMode.Write))
                    {
                        using (StreamWriter theStreamWriter = new StreamWriter((Stream)theCryptoStream))
                        {
                            theStreamWriter.Write(stringToEncrypt);
                        }

                        encryptedStringAsBytes = theMemoryStream.ToArray();
                    }
                }
            }
            return Convert.ToBase64String(encryptedStringAsBytes);
        }

        /// <summary>
        /// Decrypts a given string.
        /// </summary>
        /// <param name="stringToDecrypt">The string to decrypt.</param>
        /// <returns>The decrypted string</returns>
        public static string DecryptString(string stringToDecrypt)
        {
            if (stringToDecrypt == null || stringToDecrypt == "")
            {
                throw new ArgumentNullException("String to decrypt must not be null or empty");
            }

            byte[] iv = new byte[16];
            byte[] encryptedStringAsBytes = Convert.FromBase64String(stringToDecrypt);

            using (Aes aes = Aes.Create())
            {
                aes.Key = Encoding.UTF8.GetBytes(key);
                aes.IV = iv;
                ICryptoTransform theDecryptor = aes.CreateDecryptor(aes.Key, aes.IV);

                using (MemoryStream theMemoryStream = new MemoryStream(encryptedStringAsBytes))
                {
                    using (CryptoStream theCryptoStream = new CryptoStream((Stream)theMemoryStream, theDecryptor, CryptoStreamMode.Read))
                    {
                        using (StreamReader theStreamReader = new StreamReader((Stream)theCryptoStream))
                        {
                            return theStreamReader.ReadToEnd();
                        }
                    }
                }
            }
        }
    }
}
