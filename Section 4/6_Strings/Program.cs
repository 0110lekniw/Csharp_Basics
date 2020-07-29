using System;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstName = "Adrian";
            var lastName = "Chojnacki";

            var fullName = firstName + " " + lastName;

            var myFullName = string.Format("My name is {0} {1}", firstName, lastName);

            var names = new string[3] { "John", "Maciej", "Maria" };

            var formattedNames = string.Join(",", names);
            Console.WriteLine( formattedNames);


            var text = "Hi John\nLook into the following paths\nc:\\folder1\\folder2\\folder3";
            //verbatum
            var text2 = @"Hi John
Look into the following paths
c:\folder1\folder2\folder3";

            Console.WriteLine(text);
            Console.WriteLine(text2);
        }
    }
}
