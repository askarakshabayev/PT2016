using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Complex
{
    class Program
    {
        static void Main(string[] args)
        {
            Complex c = new Complex(5, 6);
            Complex d = new Complex(6, 7);
            Complex e = ((c + d) + c) + d;
            Console.WriteLine(e);
            Console.ReadKey();
        }
    }
}
