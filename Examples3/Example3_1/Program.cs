using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example3_1
{
    class Program
    {
        static void Main(string[] args)
        {
            F4();
        }

        static void F1()
        {
            // FileStream, StreamReader, StreamWriter
            FileStream fs = new FileStream("input.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            StreamWriter sw = new StreamWriter(fs);
            sw.WriteLine("Hello world");
            sw.Close();
            fs.Close();
        }
        static void F2()
        {
            FileStream fs = new FileStream("input.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            StreamReader sr = new StreamReader(fs);
            string s = sr.ReadLine();
            Console.WriteLine(s);
            sr.Close();
            fs.Close();
            Console.ReadKey();
        }
        static void F3()
        {
            FileStream fs1 = new FileStream("input.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            FileStream fs2 = new FileStream("output.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);

            StreamReader sr = new StreamReader(fs1);
            StreamWriter sw = new StreamWriter(fs2);

            string[] token = sr.ReadLine().Split(',');

            int sum = 0;    
            foreach (string s in token)
            {
                sum += int.Parse(s);
            }
            sw.WriteLine(sum);
            sw.Close();
            sr.Close();
            fs1.Close();
            fs2.Close();
        }

        static void F4()
        {
            FileStream fs = new FileStream("input.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            StreamReader sr = new StreamReader(fs);
            Console.WriteLine(sr.ReadToEnd());
            sr.Close();
            fs.Close();
            Console.ReadKey();
        }
    }
}

