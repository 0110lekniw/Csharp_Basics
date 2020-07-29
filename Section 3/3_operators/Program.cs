using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace operators
{
    class Program
    {
        static void Main(string[])
        {
            var a = 10;
            var b = 3;
            var c = 2;

            //Mathematical Operators

            //Adding
            Console.WriteLine(a + b);
            //Dividing - integer result
            Console.WriteLine(a / b);
            //Dividing - float result
            Console.WriteLine(a / (float)b);
            // Operators Precedence
            Console.WriteLine(a + b * c);

            //Logical Operators

            //Compairment
            Console.WriteLine(a > b);
            Console.WriteLine(a == b);
            Console.WriteLine(a != b);
            //NOT
            Console.WriteLine(!(a != b));
            //AND
            Console.WriteLine(c > b && c < a);
            //OR
            Console.WriteLine(c > b || c < a);

        }
    }
}
