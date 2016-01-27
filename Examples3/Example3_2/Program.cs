using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example3_2
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.SetCursorPosition(10, 10);
                ConsoleKeyInfo pressKey = Console.ReadKey();
                if (pressKey.Key == ConsoleKey.LeftArrow)
                    Console.WriteLine("Left");
                if (pressKey.Key == ConsoleKey.RightArrow)
                    Console.WriteLine("Right");
                if (pressKey.Key == ConsoleKey.UpArrow)
                    Console.WriteLine("Up");
                if (pressKey.Key == ConsoleKey.
                    )
                    Console.WriteLine("Down");

                if (pressKey.Key == ConsoleKey.Escape)
                    break;
            }
            

            Console.ReadKey();

        }
    }
}
