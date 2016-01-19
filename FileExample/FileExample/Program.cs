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
            Complex c = new Complex(5, 6);
            Complex d = new Complex(6, 7);

            Complex q = c + d;

            Console.WriteLine(c);
            Console.ReadKey();
        }
    }
}
