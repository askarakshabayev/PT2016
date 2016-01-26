using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileExampleLecture4
{
    class Program
    {

        public static void WalkTreeDirectory(DirectoryInfo d, int depth)
        {
            try {
                FileInfo[] files = d.GetFiles();
                foreach (FileInfo file in files)
                {
                    for (int i = 0; i < depth; i++)
                        Console.Write("  ");
                    Console.WriteLine("File name: {0}, Size: {1}", file.Name, file.Length);
                }

                DirectoryInfo[] directories = d.GetDirectories();
                foreach (DirectoryInfo di in directories)
                {
                    for (int i = 0; i < depth; i++)
                        Console.Write("  ");
                    Console.WriteLine("Directory name:" + di.Name);
                    WalkTreeDirectory(di, depth + 1);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.ReadKey();
            }
        }
        static void Main(string[] args)
        {
            
            DirectoryInfo d = new DirectoryInfo(@"c:\windows");
            
            if (d.Exists)
            {
                Console.WriteLine(d.Name);
                Console.WriteLine(d.FullName);
                WalkTreeDirectory(d, 0);
            }
            
            

            Console.ReadKey();
            }
    }
}
