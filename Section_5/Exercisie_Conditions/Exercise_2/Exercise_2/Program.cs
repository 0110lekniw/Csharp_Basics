using System;

namespace Exercise_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string lineOne;
            string lineTwo;
            int numberOne;
            int numberTwo;
            int greaterNumber;

            Console.WriteLine("Please enter the first number:");
            lineOne  = Console.ReadLine();
            Console.WriteLine("Pleas enter the second number:");
            lineTwo = Console.ReadLine();

            try
            {
                numberOne = Convert.ToInt32(lineOne);
                numberTwo = Convert.ToInt32(lineTwo);
                greaterNumber = (numberOne > numberTwo) ? numberOne : numberTwo;
                Console.WriteLine("The {0} is bigger", greaterNumber);

            }
            catch (Exception)
            {
                Console.WriteLine("Invalid format of the number");
            }
        }
    }
}
