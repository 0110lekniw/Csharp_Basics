using System;
using System.Diagnostics;

namespace Exercise_4
{

    class Program
    {
        static void Main(string[] args)
        {
            string inputOne;
            string inputTwo;
            int speedLimit;
            int velocity;
            int points;
            string velocityCorelation;

            Console.WriteLine("Please, enter the speed limit:");
            inputOne = Console.ReadLine();
            Console.WriteLine("Please, enter the velocity:");
            inputTwo = Console.ReadLine();

            try
            {
                speedLimit = Convert.ToInt32(inputOne);
                velocity = Convert.ToInt32(inputTwo);

                var calculator = new Calculator();
                points = calculator.CalculatePoints(velocity, speedLimit);
                if (points>12)
                        Console.WriteLine(DemiritPoints.Suspended);
                else
                    Console.WriteLine("Your {0} is {1} points", DemiritPoints.Punishment, points);
            }
            catch (Exception)
            {
                Console.WriteLine("Wrong input Format.");
            }

        }
    }

}
