using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examples3
{
    class Program
    {
        static void Main(string[] args)
        {
            DirectoryInfo d = new DirectoryInfo(@"c:\testfolder");
            int cnt = Search(d);
            Console.WriteLine(cnt);
            Console.ReadKey();
        }

        static int Search(DirectoryInfo d)
        {
            FileInfo[] files = d.GetFiles();
            int cnt_files = files.Length;

            DirectoryInfo[] directories = d.GetDirectories();
            foreach(DirectoryInfo directory in directories)
            {
                cnt_files += Search(directory);
            }
            return cnt_files;
        }
    }
}
