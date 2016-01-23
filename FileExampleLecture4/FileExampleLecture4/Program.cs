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
        static void Main(string[] args)
        {
            // FileInfo, DirectoryInfo
            FileInfo f = new FileInfo(@"c:\testfolder\in1.txt");
            if (f.Exists)
            {
                Console.WriteLine("File Name: {0}", f.Name);
                Console.WriteLine("File full path: {0}", f.FullName);
                Console.WriteLine("Size: {0}", f.Length);
            }
            Console.ReadKey();
        }
    }
}
