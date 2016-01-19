using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileExample
{
    class Complex
    {
        // a = 5, b = 6 -> 5/6
        public int a, b;

        public override string ToString()
        {
            return a + "/" + b;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Complex c = new Complex();
            c.a = 5;
            c.b = 6;
            Console.WriteLine(c);
            Console.ReadKey();
        }
    }
}
