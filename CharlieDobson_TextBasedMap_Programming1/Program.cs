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
            {"█", "█", "░", "░", "░", "░", "░", "░", "█", "░", "░", "░"},
            {"░", "█", "░", "░", "░", "░", "▒", "░", "░", "░", "░", "░"},
            {"░", "░", "░", "░", "░", "▒", "▒", "░", "░", "░", "░", "░"},
            {"░", "░", "░", "░", "░", "▒", "▒", "▒", "░", "░", "░", "█"},
            {"█", "█", "░", "░", "░", "░", "▒", "▒", "▒", "░", "░", "░"},
            {"▒", "▒", "▒", "░", "░", "░", "░", "░", "▒", "░", "░", "░"},
            {"▒", "▒", "▒", "▒", "░", "░", "░", "░", "░", "░", "░", "░"},
        };

        // ░ = grass
        // ▒ = water
        // █ = mountain

        static void Main(string[] args)
        {
            DisplayMap();
            Console.ReadKey(true);
            DisplayMap(2);
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
                    else if (map[y,x] == "█")
                    {
                        Console.BackgroundColor = ConsoleColor.Gray;
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

        }

        static void DisplayMap(int scale)
        {
            for (int b = 0; b < map.GetLength(1) * scale *+ 2; b++)
            {
                Console.Write("═");
            }
            Console.Write("\n");
        }
    }
}
