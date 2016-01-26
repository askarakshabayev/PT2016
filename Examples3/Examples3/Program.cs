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
            //FileInfo f = new FileInfo(@"c:\testfolder\in1.txt");
            //Console.WriteLine(f.Length / 1024 / 1024 / 1024);

            DirectoryInfo d = new DirectoryInfo(@"c:\testfolder");
            int cnt = Search(d);
            Console.WriteLine(cnt);
            Console.ReadKey();
        }

        static int Search(DirectoryInfo d)
        {
            FileInfo[] files = d.GetFiles();
            int cnt_files = files.Length;
            return cnt_files;
        }
    }
}
