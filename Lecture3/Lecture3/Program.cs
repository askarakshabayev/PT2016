using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture3
{
    class Program
    {
        static void WalkTreeDirectory(DirectoryInfo d, int depth)
        {
            try {
                // list all files
                foreach (FileInfo file in d.GetFiles())
                {
                    for (int i = 0; i < 2 * depth; i++)
                        Console.Write(" ");
                    Console.WriteLine("Depth: {0}, Name: {1}", depth, file.Name);
                }

                // list all folders
                foreach (DirectoryInfo directory in d.GetDirectories())
                {
                    for (int i = 0; i < 2 * depth; i++)
                        Console.Write(" ");
                    Console.WriteLine("Depth: {0}, Name: {1}", depth, directory.Name);
                    WalkTreeDirectory(directory, depth + 1);
                }
            } catch(Exception e)
            {
                Console.WriteLine(e.Message);
                Console.ReadKey();
            }
        }

        // testfolder
        // --in1.txt
        // --in2.txt
        // --test
        // ----a.txt
        // ----b.txt
        // ----c
        // ------q.txt
        // ------w.txt

        static void Main(string[] args)
        {
            DirectoryInfo d = new DirectoryInfo(@"c:\windows");
            WalkTreeDirectory(d, 1);
            Console.ReadKey();
        }
    }
}
