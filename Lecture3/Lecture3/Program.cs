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
        static void Main(string[] args)
        {
            // FileInfo
            // DirectoryInfo

            FileInfo f = new FileInfo(@"c:\testfolder\in1.txt");
            if (f.Exists)
            {
                //Console.WriteLine("File name " + f.Name + " Size " + f.Length);
                Console.WriteLine("File name {0}, Size {1}", f.Name, f.Length);
                Console.WriteLine("File fullname {0}", f.FullName);
            }
            

            Console.ReadKey();
        }
    }
}
