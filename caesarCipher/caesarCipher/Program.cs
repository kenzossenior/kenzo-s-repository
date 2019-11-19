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
            string message = encrpyt("Cheese Please!", 15, 23);
            Console.WriteLine(message);
            Console.WriteLine(Decrypt(message, 15, 23));
            Console.ReadKey();
        }

        static string encrpyt(string plaintext, int key1, int key2)
        {
            string cipherText = "";
            for (int i = 0; i < plaintext.Length; i++)
            {
                int ASCII = (int)plaintext[i];
                if (char.IsUpper(plaintext[i]))
                {
                    ASCII = ASCII - 65;
                    ASCII = ASCII + shiftKey(i, key1, key2, ASCII);
                    ASCII = ASCII + 26;
                    ASCII = ASCII % 26;
                    ASCII = ASCII + 65;
                }
                else if (char.IsLower(plaintext[i]))
                {
                    ASCII = ASCII - 97;
                    ASCII = ASCII + shiftKey(i, key1, key2, ASCII);
                    ASCII = ASCII + 26;
                    ASCII = ASCII % 26;
                    ASCII = ASCII + 97;

                }
                cipherText = cipherText + (char)ASCII;
            }
            return cipherText;
        }

        static string Decrypt(string cipherText, int key1, int key2)
        {
            string plaintext = "";
            for (int i = 0; i < cipherText.Length; i++)
            {
                int ASCII = (int)cipherText[i];
                if (char.IsUpper(cipherText[i]))
                {
                    ASCII = ASCII - 65;
                    ASCII = ASCII - shiftKey(i, key1, key2, ASCII);
                    ASCII = ASCII + 26;
                    ASCII = ASCII % 26;
                    ASCII = ASCII + 65;
                }
                else if (char.IsLower(cipherText[i]))
                {
                    ASCII = ASCII - 97;
                    ASCII = ASCII - shiftKey(i, key1, key2, ASCII);
                    ASCII = ASCII + 26;
                    ASCII = ASCII % 26;
                    ASCII = ASCII + 97;

                }
                plaintext = plaintext + (char)ASCII;
            }
            return plaintext;
        }

        static int shiftKey(int key1, int key2, int i, int ASCII)
        {
            int key;
            if (i % 2 == 0)
            {
                key = key1;
            }
            else
            {
                key = key2;
            }
            return key;
        }
    }
}
