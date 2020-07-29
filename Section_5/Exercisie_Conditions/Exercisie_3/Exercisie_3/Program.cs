using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_3
{
    class Program
    {
        static void Main(string[] args)
        {
            string lineOne;
            string lineTwo;
            int height;
            int width;
            string picturesType;

            Console.WriteLine("Please enter the height of the picture");
            lineOne = Console.ReadLine();
            Console.WriteLine("Please enter the width of the picture");
            lineTwo = Console.ReadLine();

            try
            {
                height = Convert.ToInt32(lineOne);
                width = Convert.ToInt32(lineTwo);
                picturesType = (height > width) ? "portrait" : "landscape";
                Console.WriteLine("The picture is a {0}.", picturesType);
            }
            catch (Exception)
            {
                Console.WriteLine("Wrong format of the input.");
            }
        }
    }
}
