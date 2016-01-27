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
                    y--;
                }
                if (button.Key == ConsoleKey.DownArrow)
                {
                    y++;
                }
                if (button.Key == ConsoleKey.LeftArrow)
                {
                    x--;
                }
                if (button.Key == ConsoleKey.LeftArrow)
                {
                    x--;
                }
                if (button.Key == ConsoleKey.RightArrow)
                {
                    x++;
                }
                Console.Clear();
            }
        }
    }
}
