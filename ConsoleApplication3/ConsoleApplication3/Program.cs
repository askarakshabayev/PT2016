using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    // f("testfolder") = count_of_files + f("sdf") + f("test") + f("test1)
    // f("test1") = count_of_files + f("aaa") 

    class Program
    {
        static void Main(string[] args)
        {
            F3();
            Console.ReadKey();
        }

        static void F3()
        {
            FileStream fread = new FileStream("input.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            FileStream fwrite = new FileStream("output.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);

            StreamReader sr = new StreamReader(fread);
            StreamWriter sw = new StreamWriter(fwrite);

            string[] token = sr.ReadLine().Split(',');
            // token[0] = 1
            // token[1] = 23 ...
            int sum = 0;
            for (int i = 0; i < token.Length; i++)
            {
                sum += int.Parse(token[i]);
            }
            sw.WriteLine(sum);

            sw.Close();
            sr.Close();
            fwrite.Close();
            fread.Close();
        }

        static void F2()
        {
            FileStream fs = new FileStream("output.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            StreamWriter sw = new StreamWriter(fs);
            sw.WriteLine("hello world");
            sw.Close();
            fs.Close();                
        }
        static void F1()
        {
            // FileStream
            // StreamReader
            // StreamWriter
            FileStream fs = new FileStream(@"c:\testfolder\input.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            StreamReader sr = new StreamReader(fs);
            string s = sr.ReadToEnd();
            Console.WriteLine(s);
            sr.Close();
            fs.Close();
        }
    }
}
