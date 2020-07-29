using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section_6
{
    class Exercises
    {
        //1- When you post a message on Facebook, depending on the number of people who like your post, Facebook displays different information.
        //If no one likes your post, it doesn't display anything.
        //If only one person likes your post, it displays: [Friend's Name] likes your post.
        //If two people like your post, it displays: [Friend 1] and[Friend 2] like your post.
        //If more than two people like your post, it displays: [Friend 1], [Friend 2] and[Number of Other People] others like your post.

        //Write a program and continuously ask the user to enter different names, until the user presses Enter (without supplying a name). 
        //Depending on the number of names provided, display a message based on the above pattern.
        public static void ExerciseOne()
        {
            var names = new List<string>();
            while(true)
            {
                Console.Write("Please Write a name: ");
                string input = Console.ReadLine();
                if (String.IsNullOrEmpty(input))
                    break;
                else
                    names.Add(input);
            }
            var numberOfNames = names.Count();

            if (numberOfNames == 1)
                Console.WriteLine("{0} likes your post.", names[0]);
            else if (numberOfNames == 2)
                Console.WriteLine("{0} and {1} like your post.", names[0], names[1]);
            else
                Console.WriteLine("{0}, {1} and {2} others like your post.", names[0], names[1], (numberOfNames-2));
        }


        //2- Write a program and ask the user to enter their name.
        //Use an array to reverse the name and then store the result in a new string. 
        //Display the reversed name on the console.
        public static void ExerciseTwo()
        {
            

            Console.Write("Please, enter your name: ");
            string input = Console.ReadLine();

            var name = new List<char>();
            for (var i = 0; i < input.Length; i++)
                name.Add(input[i]);
            name.Reverse();

            Console.Write("Your reversed name is: ");
            foreach (var character in name)
                Console.Write(character);
            Console.WriteLine();

        }

        //Example 
        
        public static void Exercise2()
        {
            Console.Write("What's Your Name? ");
            var name = Console.ReadLine();

            var array = new char[name.Length];
            for (var i = name.Length; i > 0; i--)
                array[name.Length - i] = name[i - 1];

            var reversed = new string(array);
            Console.WriteLine("Reversed name is "+reversed);
        }


        ///3- Write a program and ask the user to enter 5 numbers.
        ///If a number has been previously entered, display an error message and ask the user to re-try. 
        ///Once the user successfully enters 5 unique numbers, sort them and display the result on the console.
        public static void ExerciseThree()
        {
            var numbers = new List<int>();
            for (var i = 0; i < 5; i++)
            {
                Console.Write("Please write first number: ");
                var input = Convert.ToInt32(Console.ReadLine());
                if (numbers.Count == 0)
                    numbers.Add(input);
                else if (numbers.IndexOf(input) == -1)
                    numbers.Add(input);
                else
                {
                    Console.WriteLine("Error: Reentered number. Try again");
                    i--;
                }
            }
            numbers.Sort();
            Console.Write("Your numbers are as follow: ");
            foreach(var number in numbers)
                Console.Write(number + ", " );
        }


        ///4- Write a program and ask the user to continuously enter a number or type "Quit" to exit. 
        ///The list of numbers may include duplicates.
        ///Display the unique numbers that the user has entered.
        public static void ExerciseFour()
        {
            var numbers = new List<int>();
            while(true)
            {
                Console.Write("Please write a number or Quit to exit: ");
                var input = Console.ReadLine();
                if (input == "Quit")
                    break;
                else
                    numbers.Add(Convert.ToInt32(input));
            }
            var duplicatedNumbers = new List<int>();
            for (var i = 0; i<numbers.Count; i++)
            {
                if (numbers.IndexOf(numbers[i]) != numbers.LastIndexOf(numbers[i]))
                {
                    var duplication = numbers[i];
                    while (numbers.IndexOf(duplication) != -1)
                        numbers.Remove(duplication);
                    duplicatedNumbers.Add(duplication);
                }
                    
            }
            Console.Write("Your duplicated numbers are as follow: ");
            foreach (var number in duplicatedNumbers)
                Console.Write(number + ", ");
        }


        ///5- Write a program and ask the user to supply a list of comma separated numbers (e.g 5, 1, 9, 2, 10). 
        ///If the list is empty or includes less than 5 numbers, display "Invalid List" and ask the user to re-try; otherwise, display the 3 smallest numbers in the list.
        public static void ExerciseFive()
        {
            var numbers = new List<string>();
            Console.Write("Please write a serie of at least 5 numbers seperetade with comma: ");
            string input = Console.ReadLine();
            numbers.AddRange(input.Split(','));
            if (numbers.Count<5 || numbers.Count==0)
                Console.WriteLine("Invalid List");
            else
            {
                numbers.Sort();
                Console.Write(" The three smallest of given numbers are as follow: ");
                for (var i = 0; i < 3; i++)
                    Console.Write(numbers[i] + ", ");
            }  
        }
    }
}
