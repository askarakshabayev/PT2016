using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Complex
    {
        // fields
        // methods
        public int a, b; // a / b

        public void Print()
        {
            Console.WriteLine(a + "/" + b);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Complex c = new Complex();
            c.a = 5;
            c.b = 6;
            c.Print();
            Console.ReadKey();                   
        }
    }
}
