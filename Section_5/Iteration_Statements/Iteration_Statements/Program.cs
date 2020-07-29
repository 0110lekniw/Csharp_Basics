using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Iteration_Statements
{
    class Program
    {
        static void Main(string[] args)
        {
            Exercise.ExerciseFive();
        }

        public static void DemoFor()
        {
            for (var i = 1; i <= 10; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }

            for (var i = 10; i >= 1; i--)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }

        public static void DemoForeach()
        {
            var numbers = new int[] { 1, 2, 3, 4, 5, 6, 7 };
            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }
        }

        public static void DemoWhile()
        {
            while (true)
            {
                Console.Write("Type your name:");
                var input = Console.ReadLine();

                if (!String.IsNullOrWhiteSpace(input))
                {
                    Console.WriteLine("Echo: {0}", input);
                    continue;
                }
                break;

            }
        }

        public static void DemoRandom()
        {
            var random = new Random();

            const int passwordLength = 10;

            char[] buffer = new char[passwordLength];

            for (var i = 0; i < passwordLength; i++)
                buffer[i]  = (char)('a' + random.Next(0, 26));

            var password = new string(buffer);

            Console.WriteLine(password);

        }
    }
}
