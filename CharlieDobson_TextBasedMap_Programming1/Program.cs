using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharlieDobson_TextBasedMap_Programming1
{
    internal class Program
    {
        static string[,] map = 
        {   
            {"▓", "▓", "▓", "░", "░", "█", "█", "█", "█", "░", "░", "░", "█", "█", "█", "█", "█"},
            {"░", "▓", "░", "░", "█", "█", "▒", "█", "░", "░", "░", "░", "░", "█", "█", "█", "░"},
            {"█", "░", "░", "░", "█", "▒", "▒", "█", "░", "░", "░", "░", "░", "█", "█", "░", "░"},
            {"█", "█", "░", "░", "█", "▒", "▒", "█", "█", "█", "░", "░", "░", "░", "░", "░", "░"},
            {"█", "█", "█", "░", "█", "█", "▒", "▒", "▒", "█", "░", "░", "░", "░", "░", "░", "░"},
            {"▒", "▒", "▒", "░", "░", "█", "█", "█", "▒", "█", "░", "░", "░", "░", "░", "░", "░"},
            {"▒", "▒", "▒", "▒", "░", "░", "█", "█", "█", "█", "░", "░", "░", "░", "▒", "▒", "▒"},
            {"█", "█", "█", "░", "░", "░", "░", "█", "█", "░", "░", "░", "░", "░", "▒", "▒", "▒"},
            {"█", "█", "░", "░", "░", "░", "░", "░", "█", "░", "░", "░", "░", "░", "▒", "▒", "▓"},
            {"▓", "█", "░", "░", "░", "░", "░", "░", "░", "░", "░", "░", "░", "░", "▓", "▓", "▓"},
            {"▓", "▓", "░", "░", "░", "░", "░", "░", "░", "░", "░", "░", "░", "▓", "▓", "▓", "▓"},
            {"▓", "▓", "▓", "░", "░", "░", "░", "░", "░", "░", "░", "░", "░", "░", "▓", "▓", "▓"},
            {"▓", "▓", "▓", "▓", "░", "░", "░", "░", "░", "░", "░", "░", "░", "░", "░", "▓", "▓"},
        };

        // ░ = grass
        // ▒ = water
        // ▓ = mountain
        // █ = trees

        static void Main(string[] args)
        {
            DisplayMap();
            Console.ReadKey(true);
            Console.Clear();
            DisplayMap(2);
            Console.ReadKey(true);
        }

        static void DisplayMap()
        {
            for(int b = 0; b < map.GetLength(1) + 2; b++)
            {
                Console.Write("═");
            }
            Console.Write("\n");
            
            for(int y = 0; y < map.GetLength(0); y++)
            {
                Console.Write("║");
                for (int x = 0; x < map.GetLength(1); x++)
                {
                    if (map[y, x] == "▒")
                    {
                        Console.BackgroundColor = ConsoleColor.Blue;
                    }
                    else if (map[y,x] == "░")
                    {
                        Console.BackgroundColor = ConsoleColor.Green;
                    }
                    else if (map[y,x] == "▓")
                    {
                        Console.BackgroundColor = ConsoleColor.Gray;
                        Console.ForegroundColor = ConsoleColor.Gray;
                    }
                    else if (map[y,x] == "█")
                    {
                        Console.BackgroundColor = ConsoleColor.DarkGreen;
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                    }

                    Console.Write(map[y, x]);
                    Console.ResetColor();
                }
                Console.Write("║");
                Console.Write("\n");
            }

            for (int b = 0; b < map.GetLength(1) + 2; b++)
            {
                Console.Write("═");
            }
            Console.Write("\n");

            Console.WriteLine(" ");
            Legand();

        }

        static void DisplayMap(int scale)
        {
            for (int b = 0; b < map.GetLength(1) * scale + 2; b++)
            {
                Console.Write("═");
            }
            Console.Write("\n");

            for (int y = 0; y < map.GetLength(0); y++)
            {
                for(int s = 0; s < scale; s++)
                {
                    Console.Write("║");
                    for (int x = 0; x < map.GetLength(1); x++)
                    {
                        for(int i = 0; i < scale; i++ )
                        {
                            if (map[y, x] == "▒")
                            {
                                Console.BackgroundColor = ConsoleColor.Blue;
                            }
                            else if (map[y, x] == "░")
                            {
                                Console.BackgroundColor = ConsoleColor.Green;
                            }
                            else if (map[y, x] == "▓")
                            {
                                Console.BackgroundColor = ConsoleColor.Gray;
                                Console.ForegroundColor = ConsoleColor.Gray;
                            }
                            else if (map[y, x] == "█")
                            {
                                Console.BackgroundColor = ConsoleColor.DarkGreen;
                                Console.ForegroundColor = ConsoleColor.DarkGreen;
                            }

                            Console.Write(map[y, x]);
                            Console.ResetColor();
                        }
                        
                    }
                    Console.Write("║");
                    Console.Write("\n");
                }
                
            }

            for (int b = 0; b < map.GetLength(1) * scale + 2; b++)
            {
                Console.Write("═");
            }
            Console.Write("\n");

            Console.WriteLine(" ");
            Legand();
        
        }

        static void Legand()
        {
            Console.WriteLine("LEGAND");
            Console.WriteLine(" ");
            Console.WriteLine("░ = grass");
            Console.WriteLine("▒ = water");
            Console.WriteLine("▓ = mountain");
            Console.WriteLine("█ = trees");
        }
    }
}
