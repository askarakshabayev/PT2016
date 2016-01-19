using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleLecture2
{
    class Program
    {
        public static void WalkDirectoryTree(DirectoryInfo d, int depth)
        {
            try {
                foreach (FileInfo file in d.GetFiles())
                {
                    Console.WriteLine("Depth={0}, File={1}", depth, file.Name);
                }
                foreach (DirectoryInfo directory in d.GetDirectories())
                {
                    Console.WriteLine("Depth={0}, Directory={1}", depth, directory.Name);
                    WalkDirectoryTree(directory, depth + 1);
                }
            }catch(Exception e)
            {
                Console.WriteLine(e.Message);
                Console.ReadKey();
            }
        }
        static void Main(string[] args)
        {
            DirectoryInfo d = new DirectoryInfo(@"c:\windows");
            WalkDirectoryTree(d, 0);
            //FileInfo[] files = d.GetFiles();
            //foreach(FileInfo file in files)
            //{
            //    Console.WriteLine("File: {0}", file.Name);
            //}

            //DirectoryInfo[] directories = d.GetDirectories();
            //foreach(DirectoryInfo di in directories)
            //{
                
            //    Console.WriteLine("Directory: {0}", di.Name);
            //}

            Console.ReadKey();
        }
    }
}
