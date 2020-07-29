using System;
using System.Collections.Generic;

namespace Section_6
{
    class Program
    {
        static void Main(string[])
        {
            Exercises.ExerciseFive();
        }

        public static void DemoArrays()
        {
            var numbers = new[] { 3, 7, 9, 2, 14, 6 };

            // Length
            Console.WriteLine("Length: " +numbers.Length);

            //IndexOf()
            var index = Array.IndexOf(numbers, 9);
            Console.WriteLine("Index of 9: " + index);

            //Clear()
            Array.Clear(numbers, 0, 2);

            foreach(var n in numbers)
                Console.WriteLine(n);

            //Copy()
            int[] another = new int[3];
            Array.Copy(numbers, another, 3);

            Console.WriteLine("Effect if Copy()");
            foreach (var n in another)
                Console.WriteLine(n);

            //Sort 
            Array.Sort(numbers);
            Console.WriteLine("Effect of Sort()");
            foreach(var n in numbers)
                Console.WriteLine(n);

            //Reverse()
            Array.Reverse(numbers);
            Console.WriteLine("Effect of Reverse()");
            foreach (var n in numbers)
                Console.WriteLine(n);
        }

        public static void DemoList()
        {
            var numbers = new List<int>() { 1, 2, 3, 4 };

            //Add()
            numbers.Add(1);

            //AddRange()
            numbers.AddRange(new int[3] { 5, 6, 7 });

            foreach (var number in numbers)
                Console.WriteLine(number);
            Console.WriteLine();
            //Remove()
            
            for (var i=0; i < numbers.Count; i++)
            {
                if (numbers[i] == 1)
                    numbers.Remove(numbers[i]);
            }
            foreach (var number in numbers)
                Console.WriteLine(number);

            //IndexOf()
            Console.WriteLine();
            Console.WriteLine(numbers.IndexOf(1));
            Console.WriteLine(numbers.LastIndexOf(1));


            //Clear
            numbers.Clear();

            //Contains()

            //Count
            Console.WriteLine("Count: " + numbers.Count);

        }
    }

}
