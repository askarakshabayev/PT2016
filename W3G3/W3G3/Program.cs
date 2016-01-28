using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W3G3
{
    class Program
    {
        static int FilesCnt(DirectoryInfo directory)
        {
            FileInfo[] files = directory.GetFiles();
            int cnt = files.Length;
            // cnt = 2
            foreach(DirectoryInfo d in directory.GetDirectories())
            {
                cnt += FilesCnt(d);
            }

            return cnt;
        }
        static void Main(string[] args)
        {
            DirectoryInfo directory = new DirectoryInfo(@"c:\testfolder");
            int cnt = FilesCnt(directory);
            Console.WriteLine(cnt);

            Console.ReadKey();
        }
    }
}
