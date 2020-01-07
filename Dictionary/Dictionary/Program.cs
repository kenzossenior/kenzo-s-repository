using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> Dictionary = new Dictionary<string, int>();
            string filename = "ah.txt";
            try
            {
                using (StreamReader currentfile = new StreamReader(filename))
                {
                    do
                    {
                        CountWords(currentfile.ReadLine().ToLower(), Dictionary);
                    } while (currentfile.Peek() != -1);

                    outputWordCount(Dictionary);
                }
            }
            catch(Exception)
            {
                Console.WriteLine("File not found");
                throw;
            }

                Console.ReadKey();
        }

        static void CountWords(string sentence, Dictionary<string, int> Dictionary)
        {
            string[] separators = { ".", ",", "!", ";", ":", "?" };
            string[] wordArray = sentence.Split(separators, StringSplitOptions.RemoveEmptyEntries);

            foreach(var word in wordArray)
            {
                if (Dictionary.ContainsKey(word))
                {
                    Dictionary[word] = Dictionary[word] + 1;
                }
                else
                {
                    Dictionary.Add(word, 1);
                }
            }
        }

        static void outputWordCount(Dictionary<string, int> Dictionary)
        {
            foreach (KeyValuePair<string, int> definition in Dictionary)
            {
                Console.WriteLine(definition.Key + " " + definition.Value);
            }
        }
    }
}
