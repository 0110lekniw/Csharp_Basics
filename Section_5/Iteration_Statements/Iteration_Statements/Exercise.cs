using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace Iteration_Statements
{
    public class Exercise
    {
        /// 1- Write a program to count how many numbers between 1 and 100 are divisible by 3 with no remainder.
        /// Display the count on the console.

        public static void ExerciseOne()
        {
            var result = 0;
            for (var i = 1; i<=100; i++)
            {
                if (i % 3 == 0)
                    result += 1;
            }
            Console.WriteLine("Between 1 and 100 there is {0} numbers", result);
        }

        ///2- Write a program and continuously ask the user to enter a number or "ok" to exit. 
        ///Calculate the sum of all the previously entered numbers and display it on the console.

        public static void ExerciseTwo()
        {
            while (true)
            {
                Console.Write("Write number or ok to exit: ");
                var input = Console.ReadLine();
                try
                {
                    Convert.ToInt32(input);
                }
                catch (Exception)
                {
                    Console.WriteLine("Wrong Input");
                }
                if (input == "ok")
                    break;
                Console.WriteLine(input);
            }
        }

        ///3- Write a program and ask the user to enter a number.
        ///Compute the factorial of the number and print it on the console. 
        ///For example, if the user enters 5, the program should calculate 5 x 4 x 3 x 2 x 1 and display it as 5! = 120.

        public static void ExerciseThree()
        {
            Console.Write("Write number to calculate the factorial: ");
            var number = Convert.ToInt32(Console.ReadLine());
            var factorial = 1;
            for (var i = 1; i <= number; i++)
                factorial *= i;
            Console.WriteLine("{0}! = {1}", number, factorial);

        }


        ///4- Write a program that picks a random number between 1 and 10. 
        ///Give the user 4 chances to guess the number.
        ///If the user guesses the number, display “You won"; otherwise, display “You lost". 
        ///(To make sure the program is behaving correctly, you can display the secret number on the console first.)

        public static void ExerciseFour()
        {
            var random = new Random();
            var number = random.Next(1, 10);
            for (var i = 0; i<=3; i++)
            {
                Console.Write("Guess the number: ");
                int guess;
                guess =  Convert.ToInt32(Console.ReadLine());
                if (guess == number)
                {
                    Console.WriteLine("You Win");
                    break;
                }
                else if(i == 3)
                        Console.WriteLine("You Lose");
                else
                    Console.WriteLine("Try one more time");
            }

        }

        ///5- Write a program and ask the user to enter a series of numbers separated by comma.
        ///Find the maximum of the numbers and display it on the console.
        ///For example, if the user enters “5, 3, 8, 1, 4", the program should display 8.

        public static void ExerciseFive()
        {
            Console.Write("Write a serie of numbers seperated by comma: ");

            var input = Console.ReadLine();
            var numbers = input.Split(',');

            var max = Convert.ToInt32(numbers[0]);

            foreach (var str in numbers)
            {
                var number = Convert.ToInt32(str);
                if (max < number)
                    max = number;
            }
            Console.WriteLine("The maximum value of writen serie is {0}", max);
            
        }
    }
}
