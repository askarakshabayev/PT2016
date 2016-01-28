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
        static void Main(string[] args)
        {
        }
        static void F3()
        {
            FileStream finput = new FileStream("input.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            FileStream foutput = new FileStream("output.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            StreamReader sr = new StreamReader(finput);
            StreamWriter sw = new StreamWriter(foutput);

            string s = sr.ReadLine();
            string[] token = s.Split(',');
            // token[0] = 1
            // token[1] = 12 ...
            int sum = 0;
            foreach(string q in token)
            {
                sum += int.Parse(q);
            }

            sw.WriteLine(sum);

            sw.Close();
            sr.Close();
            finput.Close();
            foutput.Close();
        }
        static void F2()
        {
            FileStream fs = new FileStream("output.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            StreamWriter sw = new StreamWriter(fs);
            string s = Console.ReadLine();

            sw.WriteLine(s);
            Console.ReadKey();
            sw.Close();
            fs.Close();
        }
        static void F1()
        {
            // FileStream, StreamWriter, StreamReader
            // file name, FileMode, FileAccess
            FileStream fs = new FileStream("input.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            StreamReader sr = new StreamReader(fs);
            string text = sr.ReadToEnd();
            Console.WriteLine(text);

            Console.ReadKey();
        }
    }
}
