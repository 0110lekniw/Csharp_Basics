using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Primitives
{
    class Program
    {
        static void Main(string[] args)
        {
            //Primitive Types
            byte b = 2;
            int i = 10;
            float f = 2.85f;
            char character = 'A';
            string str = "Adrian";
            bool boolean = true;
            const float Pi = 3.14f;

            //max min value
            Console.WriteLine("{0}{1}", float.MinValue, float.MaxValue);

            //Conversion

            //Implicit
            byte number1 = 1;
            int number2 = number1;
            //Explicit
            int number3 = 123;
            byte number4 = (byte)number3;
            //Conversion
            string number = "1234";
            int number5 = Convert.ToInt32(number);

            //Exception Error 
            try
            {
                byte smallNumber = Convert.ToByte(number);
            }
            catch (Exception)
            {
                Console.WriteLine("Cannot Convert to Byte");
            }

        }
    }
}
