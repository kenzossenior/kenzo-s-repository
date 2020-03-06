using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dijkstra
{
    class Program
    {
        static void Main(string[] args)
        {
            
                int[,] graph = new int[6, 6];
                string[] towns = { "Preston", "Lancaster", "Blackpool", "Southport", "Liverpool", "Manchester" };
                int numberofnodes = 6;
                string town1;
                string town2;

                LoadData(ref graph);

                bool running = true;
                while (running == true)
                {
                    switch (Menu())
                    {
                        case (1):
                            Console.Write("Enter town 1: ");
                            town1 = Console.ReadLine();
                            FindTown(towns, town1);

                            Console.Write("Enter town 2: ");
                            town2 = Console.ReadLine();
                            FindTown(towns, town2);

                            if (FindTown(towns, town1) == 7 || FindTown(towns, town2) == 7)
                            {
                                Console.WriteLine("No data for these towns.");
                            }
                            else if ((graph[FindTown(towns, town1), FindTown(towns, town2)]) != 0)
                            {
                                Console.WriteLine("Connected by road.");
                                Console.WriteLine($"Distance between {town1} and {town2} is {graph[FindTown(towns, town1), FindTown(towns, town2)]} miles.");
                            }
                            else
                            {
                                Console.WriteLine("Not directly connected by road.");
                            }
                            Console.ReadKey();
                            break;
                        case (2):
                            ShortestPath(TownChoice(), TownChoice(), numberofnodes, graph, towns);
                            break;
                        case (3):
                            break;
                        default:
                            Console.WriteLine("Invalid input.");
                            break;
                    }
                }
                Console.WriteLine("Press any key to end.");
                Console.ReadKey();

            }

            static public int Menu()
            {
                int choice;
                Console.WriteLine("1) Check two towns direct connection.");
                Console.WriteLine("2) Check two towns shortest path.");
                Console.WriteLine("3) End.");
                Console.Write("Enter a number to choose: ");
                int.TryParse(Console.ReadLine(), out choice);
                return choice;
            }

            static public void LoadData(ref int[,] graph)
            {
                //Preston out
                graph[0, 1] = 22;
                graph[0, 2] = 17;
                graph[0, 3] = 20;
                graph[0, 4] = 37;
                graph[0, 5] = 33;
                //Lancaster out
                graph[1, 0] = 22;
                graph[1, 2] = 33;
                //Blackpool out
                graph[2, 0] = 22;
                graph[2, 1] = 33;
                //Southport out
                graph[3, 0] = 22;
                graph[3, 4] = 20;
                //Liverpool out
                graph[4, 0] = 22;
                graph[4, 3] = 20;
                graph[4, 5] = 35;
                //Manchester out
                graph[5, 0] = 22;
                graph[5, 4] = 35;
            }

            static public int FindTown(string[] towns, string town)
            {
                int location = 7;
                for (int i = 0; i < 6; i++)
                {
                    if (town == towns[i])
                    {
                        location = i;
                    }
                    if ((i == 5) && (location == 7))
                    {
                        Console.WriteLine($"Error. {town} is invalid.");
                    }
                }
                return location;
            }

            static public int TownChoice()
            {
                int choice;
                Console.WriteLine("1) Preston");
                Console.WriteLine("2) Lancaster");
                Console.WriteLine("3) Blackpool");
                Console.WriteLine("4) Southport");
                Console.WriteLine("5) Liverpool");
                Console.WriteLine("6) Manchester");
                Console.Write("Enter a number to choose: ");
                int.TryParse(Console.ReadLine(), out choice);
                return choice - 1;
            }

            static public void ShortestPath(int N1, int N2, int numberofnodes, int[,] graph, string[] towns)
            {
                int[] minDistance = new int[numberofnodes];
                bool[] nodeFixed = new bool[numberofnodes];
                string[] route = new string[numberofnodes];

                for (int i = 0; i < numberofnodes; i++)
                {
                    minDistance[i] = int.MaxValue;
                    nodeFixed[i] = false;
                    route[i] = towns[i];
                }

                minDistance[N1] = 0;
                CurrentNode(N1, ref minDistance, ref nodeFixed, ref route, numberofnodes, graph, towns);

                Console.WriteLine($"Shortest path = {route[N2]} Distance = {minDistance[N2]}");
            }
            static public void CurrentNode(int thisNode, ref int[] minDistance, ref bool[] nodeFixed, ref string[] route, int numberofnodes, int[,] graph, string[] towns)
            {
                int distanceToNode = 0;
                string thisRoute;

                distanceToNode = minDistance[thisNode];
                nodeFixed[thisNode] = true;

                thisRoute = route[thisNode] + " ";

                for (int i = 0; i < numberofnodes; i++)
                {
                    if (nodeFixed[i] == false)
                    {
                        if (graph[thisNode, i] > 0)
                        {
                            if (minDistance[i] > distanceToNode + graph[thisNode, i])
                            {
                                minDistance[i] = distanceToNode + graph[thisNode, i];
                                route[i] = thisRoute + towns[i];
                            }
                        }
                    }
                }

                int thisMin = int.MaxValue;

                for (int i = 0; i < numberofnodes; i++)
                {
                    if (nodeFixed[i] == false)
                    {
                        if (minDistance[i] < thisMin)
                        {
                            thisNode = i;
                            thisMin = minDistance[i];
                        }
                    }
                }

                if (thisMin != int.MaxValue)
                {
                    CurrentNode(thisNode, ref minDistance, ref nodeFixed, ref route, numberofnodes, graph, towns);
                }
            }
        
    }
}
