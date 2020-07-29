using System;

namespace Exercise_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string line;
            int number;

            Console.WriteLine("Please Enter a number between 1 and 10");
            Console.WriteLine("Your number is: ");
            line = Console.ReadLine();

            try
            {
                number = Convert.ToInt32(line);
                string solution = (number > 1 && number < 10) ? "Valid" : "Invalid";
                Console.WriteLine(solution);
            }
            catch (Exception)
            {
                Console.WriteLine("Didn't I ask to write a number?");
            }
               
        }
    }
}
