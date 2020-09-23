using System;
using System.Collections.Generic;
using System.Text;

namespace tutorialTextBasedAdventureGame
{
    public static class Game
    {
        static String CharacterName;

        public static void StartGame()
        {
            Dialog("Adventure Game");
            Dialog("Press any key to continue");
            Console.ReadKey();
            Console.Clear();
            NameCharacter();
            Console.Clear();

            Console.WriteLine("Are you gay? A = Yes B = Yes");
            Choice();
        }
        public static void NameCharacter()
        {
            Console.WriteLine("Enter Character Name");
            CharacterName = Console.ReadLine();
            Console.WriteLine($"Character name: {CharacterName}");
        }

        static void Dialog(string message)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(message);
            Console.ResetColor();
        }

        static void Dialog(string message, string colour)
        {
            if (colour == "red")
            { Console.ForegroundColor = ConsoleColor.Red; }
            else if (colour == "green")
            { Console.ForegroundColor = ConsoleColor.Green; }
            else if (colour == "yellow")
            { Console.ForegroundColor = ConsoleColor.Yellow; }
            else
            { Console.ForegroundColor = ConsoleColor.White; }

            Console.WriteLine(message);
            Console.ResetColor();
        }

        static void Choice()
        {
            string input = "";
            Console.WriteLine("Choice: A or B");
            input = Console.ReadLine();
            input.ToUpper();
            if (input == "A")
            {
                Console.WriteLine("You chose A");
            }
            else
            {
                Console.WriteLine("You chose B");
            }
        }
    }


}
