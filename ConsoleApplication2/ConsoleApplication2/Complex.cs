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

        public Complex(int a, int b)
        {
            this.a = a;
            this.b = b;
        }
        public override string ToString()
        {
            return a + "/" + b;
        }
        public static Complex operator +(Complex c1, Complex c2)
        {
            // TODO: wrong version of sum 
            Complex c3 = new Complex(c1.a + c2.a, c1.b + c2.b);
            return c3;
        }
    }
}
