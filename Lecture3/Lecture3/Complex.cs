using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture3
{
    class Complex
    {
        public int a, b;
        public Complex(int _a, int _b)
        {
            a = _a;
            b = _b;
        }

        public override string ToString()
        {
            return a + "/" + b;
        }

        public static int gcd(int a, int b)
        {
            // a = 24 -> 0
            // b = 36 -> 12
            while (a > 0 && b > 0)
            {
                if (a < b)
                    b = b % a;
                else
                    a = a % b;
            }
            return a + b;
        }

        public static Complex operator +(Complex c1, Complex c2)
        {
            Complex c3 = new Complex(c1.a + c2.a, c1.b + c2.b);
            //int g = gcd(c3.a, c3.b);
            //c3.a /= g;
            //c3.b /= g;
            return c3;
        }
    }
}
