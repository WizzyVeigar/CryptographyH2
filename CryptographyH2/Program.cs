using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.Diagnostics;

namespace CryptographyH2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Encrypter.Encrypt("Hello"));
            Console.WriteLine(Encrypter.Decrypt("Ifmmp"));
            Console.ReadLine();
        }
    }
}
