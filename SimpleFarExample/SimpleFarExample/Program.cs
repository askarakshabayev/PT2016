using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFarExample
{
    class Program
    {
        static void Main(string[] args)
        {
            int index = 0;
            DirectoryInfo directory = new DirectoryInfo(@"c:\testfolder");
            FileInfo[] files = directory.GetFiles();
            while (true)
            {
                for(int i = 0; i < files.Length; i++)
                {
                    if (index == i)
                    {
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.ForegroundColor = ConsoleColor.Black;
                    } else
                    {
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    Console.WriteLine(files[i].Name);
                }
                ConsoleKeyInfo button = Console.ReadKey();
                if (button.Key == ConsoleKey.UpArrow)
                {
                    if (index > 0)
                        index--;
                }
                if (button.Key == ConsoleKey.DownArrow)
                {
                    if (index < files.Length - 1)
                        index++;
                }
                Console.Clear();
            }
        }
    }
}
