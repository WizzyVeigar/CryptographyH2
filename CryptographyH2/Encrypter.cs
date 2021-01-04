using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptographyH2
{
    class Encrypter
    {
        public static string Encrypt(string message)
        {
            string encryptedString = string.Empty;

            for (int i = 0; i < message.Length; i++)
            {
                char oldval = message[i];
                oldval++;
                encryptedString += oldval;
            }
            return encryptedString;
        }

        public static string Decrypt(string message)
        {
            string decryptedString = string.Empty;

            for (int i = 0; i < message.Length; i++)
            {
                char oldval = message[i];
                oldval--;
                decryptedString += oldval;
            }
            return decryptedString;
        }
    }
}
