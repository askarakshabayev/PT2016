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
            DirectoryInfo d = new DirectoryInfo(@"c:\testfolder");
            FileInfo[] files = d.GetFiles();
            int index = 0;

            while (true)
            {
                for (int i = 0; i < files.Length; i++)
                {
                    if (index == i)
                    {
                        Console.BackgroundColor = ConsoleColor.DarkBlue;
                        Console.ForegroundColor = ConsoleColor.White;
                    } else
                    {
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    Console.WriteLine(files[i].Name);
                }

                ConsoleKeyInfo key = Console.ReadKey();
                if (key.Key == ConsoleKey.UpArrow)
                {
                    if (index > 0)
                        index--;
                }
                if (key.Key == ConsoleKey.DownArrow)
                {
                    if (index < files.Length - 1)
                        index++;
                }
                if (key.Key == ConsoleKey.Escape)
                    break;
                Console.Clear();
            }
        }
    }
}
