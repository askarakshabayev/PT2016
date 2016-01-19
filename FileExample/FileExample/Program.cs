using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileExample
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] token = Console.ReadLine().Split();
            int a = int.Parse(token[0]);
            int b = int.Parse(token[1]);
            int c = a + b;
            Console.WriteLine(c);
            Console.WriteLine("hello world");
            Console.ReadKey();
        }
    }
}
