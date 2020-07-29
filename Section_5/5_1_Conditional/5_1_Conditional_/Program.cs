using System;

namespace _5_1_Conditional_
{
    class Program
    {
        
        static void Main(string[] args)
        {
        /*Exemplary use of the if statment*/
            int hour = 10;
             
            if (hour > 0 && hour < 12)
            {
                System.Console.WriteLine("It's morning.");
            }
            else if (hour >= 12 && hour < 18)
            {
                System.Console.WriteLine("It's afternoon.");
            }
            else
            {
                System.Console.WriteLine("It's evening.");
            }

            /* Exemplary use of the conditional statment */
            bool isGoldCustomer = true;

            float price;
            if (isGoldCustomer)
                price = 19.95f;
            else
                price = 29.95f;

            float price_2 = (isGoldCustomer) ? 19.95f : 29.95f;

            Console.WriteLine(price);
            Console.WriteLine(price_2);

            /*Wxemplary use of switch */

            var season = Season.Autumn;

            switch (season)
            {
                case Season.Autumn:
                case Season.Summer:
                    Console.WriteLine("We've got promotion.");
                    break;

                default:
                    Console.WriteLine( "The promotion is over.");
                    break;
            }
        }
    }
}
