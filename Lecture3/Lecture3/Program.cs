using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture3
{
    class Program
    {
        static void Main(string[] args)
        {
            Complex c = new Complex(5, 6);
            Console.WriteLine(c);
            Complex d = c + c;
            Console.WriteLine(d);
            Console.ReadKey();
        }
    }
}
