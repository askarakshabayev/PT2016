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
        static void Main(string[] args)
        {
            // FileInfo
            // DirectoryInfo

            FileInfo file = new FileInfo(@"c:\testfolder\in1.txt");
            if (file.Exists)
            {
                Console.WriteLine("File name {0}, File fullname {1}", file.Name, file.FullName);
            } else
            {
                Console.WriteLine("Error");
            }
            Console.ReadKey();
        }
    }
}
