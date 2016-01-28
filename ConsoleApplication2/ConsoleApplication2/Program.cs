using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        
        static void Main(string[] args)
        {
            int x = 0, y = 0;
            while(true)
            {
                Console.SetCursorPosition(x, y);
                Console.ForegroundColor = ConsoleColor.Yellow;

                Console.Write("*");

                ConsoleKeyInfo button = Console.ReadKey();
                if (button.Key == ConsoleKey.UpArrow)
                {
                    if (y - 1 < 0)
                        y = Console.WindowHeight;
                    else
                        y--;
                }
                if (button.Key == ConsoleKey.DownArrow)
                {
                    if (y + 1 > Console.WindowHeight - 10)
                        y = 0;
                    else
                        y++;
                }
                if (button.Key == ConsoleKey.LeftArrow)
                {
                    if (x - 1 < 0)
                        x = Console.WindowWidth;
                    else
                        x--;
                }
                if (button.Key == ConsoleKey.RightArrow)
                {
                    if (x + 1 > Console.WindowWidth - 10)
                        x = 0;
                    else
                        x++;
                }
                Console.Clear();
            }
        }
    }
}
