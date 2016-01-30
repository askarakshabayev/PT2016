using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadKeyExample
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                ConsoleKeyInfo button = Console.ReadKey();
                if (button.Key == ConsoleKey.UpArrow)
                {
                    Console.BackgroundColor = ConsoleColor.Yellow;
                    Console.ForegroundColor = ConsoleColor.Black;

                    Console.WriteLine("Up");
                }
                if (button.Key == ConsoleKey.DownArrow)
                {
                    Console.BackgroundColor = ConsoleColor.Blue;
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Down");
                }
                if (button.Key == ConsoleKey.LeftArrow)
                {
                    Console.BackgroundColor = ConsoleColor.Yellow;
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("Left");
                }
                if (button.Key == ConsoleKey.RightArrow)
                {
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine("Rigth");
                }
                if (button.Key == ConsoleKey.Enter)
                {
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.Clear();
                }
                if (button.Key == ConsoleKey.Escape)
                    return;
            }
        }
    }
}
