using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caesarCipher
{
    class Program
    {
        static void Main(string[] args)
        {
            string message = encrpyt("Cheese please!", 15);
            Console.WriteLine(message);
            Console.WriteLine(Decrypt(message, 15));
        }

        static string encrpyt (string plaintext, int shiftKey)
        {
            string tempChar;
            int currentASCII;
            string cipherText = "";

            return cipherText;
        }
    }
}
