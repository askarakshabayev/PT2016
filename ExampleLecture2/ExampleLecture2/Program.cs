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
        static void watcher_changed(object sender, FileSystemEventArgs e)
        {
            Console.WriteLine("Directory changed {0}, {1}", e.GetType(), e.FullPath);
        }
        static void watcher_changed1(object sender, FileSystemEventArgs e)
        {
            Console.WriteLine("asdf {0}, {1}", e.GetType(), e.FullPath);
        }
        static void Main(string[] args)
        {
            FileSystemWatcher fw = new FileSystemWatcher();
            fw.Path = @"c:\testfolder";

            fw.Created += new FileSystemEventHandler(watcher_changed);
            fw.Created += new FileSystemEventHandler(watcher_changed1);

            fw.EnableRaisingEvents = true;

            Console.ReadKey();
        }
    }
}
