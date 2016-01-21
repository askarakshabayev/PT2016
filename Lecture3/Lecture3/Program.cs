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
        static void watcher_changed(object sender, FileSystemEventArgs e)
        {
            Console.WriteLine("Directory changed {0}, {1}", e.GetType(), e.FullPath);
        }
        static void watcher_changed1(object sender, FileSystemEventArgs e)
        {
            Console.WriteLine("Directory changed {0}, {1}", e.GetType(), e.FullPath);
        }
        static void watcher_changed2(object sender, FileSystemEventArgs e)
        {
            Console.WriteLine("Deleted {0}, {1}", e.GetType(), e.FullPath);
        }

        static void Main(string[] args)
        {
            FileSystemWatcher fw = new FileSystemWatcher();
            fw.Path = @"c:\testfolder";

            fw.Created += new FileSystemEventHandler(watcher_changed);
            fw.Created += new FileSystemEventHandler(watcher_changed1);

            fw.Deleted += new FileSystemEventHandler(watcher_changed2);
            fw.EnableRaisingEvents = true;
            Console.ReadKey();
        }
    }
}
