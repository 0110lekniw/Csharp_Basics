using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section_9_Files
{
    class Exercises
    {
        public static void ExerciseOne()
        {
            var path = @"c:\GitHub\Csharp_Basics\Section_9_Files";
            var directories = Directory.GetFiles(path, "*.txt", SearchOption.AllDirectories);

            string filePath = path;
            string textFile = path;

            for(var i = 0; i < directories.Length; i++)
                if (directories[i].Contains("Text"))
                    filePath = directories[i];

            if (File.Exists(filePath))
                textFile = File.ReadAllText(filePath);

            var words = textFile.Split(' ');
            Console.WriteLine("Number of Words is " + words.Count());

            var longestWord = words[0];
            foreach (var word in words)
                if (longestWord.Length < word.Length)
                    longestWord = word;
            Console.WriteLine("The longest word is: " + longestWord);

        }
    }
}
