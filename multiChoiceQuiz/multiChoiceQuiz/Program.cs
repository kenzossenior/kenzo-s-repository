using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace QuizNight
{
    class Program
    {
        static void Main(string[] args)
        {
            int score = 0;
            int choice = 0;
            DisplayQuizName();
            GetUserName();
            QandA[] Questions = new QandA[5];

            while (choice != 4)
            {
                choice = Menu();
                if (choice == 1)
                {
                    loadQuestions(ref Questions);
                }
                else if (choice == 2)
                {
                    WriteNew(ref Questions);
                }
                else if (choice == 3)
                {
                    PlayQuiz(ref score, Questions);
                    DisplayScore(score);
                }
            }
            AnyKey();
        }

        public struct QandA
        {
            public string questions;
            public string answer1;
            public string answer2;
            public string answer3;
            public string rightAnswer;
        }

        static void DisplayQuizName()
        {
            Console.Clear();
            Console.WriteLine("Quiz Night!");
            Console.WriteLine("============\n");
        }

        static void GetUserName()
        {
            string name;
            Console.WriteLine("Player, please enter your name...");
            Console.Write("Name: ");
            name = Console.ReadLine();
        }

        static void PlayQuiz(ref int score, QandA[] Questions)
        {

            //Create a 2D array of questions
            //Loop through the questions
            AskQuestion(ref score, Questions);
            //Call DisplayQuizName
            DisplayQuizName();
        }

        static void DisplayScore(int score)
        {
            //Display the score
            Console.WriteLine("Your score was {0}", score);
        }

        static void AskQuestion(ref int score, QandA[] Questions)
        {
            string answer;
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(Questions[i].questions);
                Console.WriteLine(Questions[i].answer1);
                Console.WriteLine(Questions[i].answer2);
                Console.WriteLine(Questions[i].answer3);
                answer = Console.ReadLine();

                if (answer == Questions[i].rightAnswer)
                {
                    Console.WriteLine("Nice one broski Gstar, you got it right");
                    score = score + 1;
                }
                else
                    Console.WriteLine("Unlucky bossman, wrong answer");
            }
        }

        static void AnyKey()
        {
            Console.WriteLine("\nPress any key to continue...\n");
            Console.ReadKey();
        }

        public static int Menu()
        {
            int input;
            Console.WriteLine("Would you like to:");
            Console.WriteLine("1) Load questions");
            Console.WriteLine("2) Write new questions");
            Console.WriteLine("3) Take the quiz");
            Console.WriteLine("4) Exit program");
            int.TryParse(Console.ReadLine(), out input);

            return input;
        }

        static void WriteNew(ref QandA[] Questions)
        {
            Console.Write("Enter a name for file:");
            string fileName = Console.ReadLine();
            using (StreamWriter CurrentFile = new StreamWriter(fileName))
            {
                for (int i = 0; i < 5; i++)
                {
                    Console.Write("Question {0}:", i + 1);
                    CurrentFile.WriteLine(Console.ReadLine());
                    Console.Write("Possible Answer 1:");
                    CurrentFile.WriteLine(Console.ReadLine().ToLower());
                    Console.Write("Possible Answer 2:");
                    CurrentFile.WriteLine(Console.ReadLine().ToLower());
                    Console.Write("Possible Answer 3:");
                    CurrentFile.WriteLine(Console.ReadLine().ToLower());
                    Console.Write("Correct Answer:");
                    CurrentFile.WriteLine(Console.ReadLine().ToLower());

                }
                Console.WriteLine("writing complete");
            }
        }

        static void loadQuestions(ref QandA[] Questions)
        {
            String fileName;

            Console.WriteLine("Enter the name of the file you want to load");
            fileName = Console.ReadLine();

            try
            {
                using (StreamReader CurrentFile = new StreamReader(fileName))
                {
                    for (int i = 0; i < 5; i++)
                    {
                        Questions[i].questions = CurrentFile.ReadLine();
                        Questions[i].answer1 = CurrentFile.ReadLine();
                        Questions[i].answer2 = CurrentFile.ReadLine();
                        Questions[i].answer3 = CurrentFile.ReadLine();
                        Questions[i].rightAnswer = CurrentFile.ReadLine();
                    }
                }
                Console.WriteLine("Writing complete");
            }
            catch (System.IO.IOException ex)
            {
                Console.WriteLine("Houston we have a problem " + ex.Message);
            }
        }

    }
}
