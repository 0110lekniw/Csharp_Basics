using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section_7_Dates
{
    class Program
    {
        static void Main(string[] args)
        {
            DemoTimeSpan();
        }

        public static void DemoDateTime()
        {
            var dateTime = new DateTime(2015, 10, 2);
            var now = DateTime.Now;
            var today = DateTime.Today;
            var hour = now.Hour;
            var minute = now.Minute;
            var tomorrow = now.AddDays(1);
            var yesterday = now.AddDays(-1);

            Console.WriteLine(now.ToLongDateString());
            Console.WriteLine(now.ToShortDateString());
            Console.WriteLine(now.ToLongTimeString());
            Console.WriteLine(now.ToShortTimeString());
            Console.WriteLine(now.ToString("yyyy-MM-dd HH:mm"));
        }

        public static void DemoTimeSpan()
        {
            // Creating
            var timeSpan = new TimeSpan(1, 2, 3);
            var timeSpan1 = new TimeSpan(1, 0, 0);
            var timeSpan2 = TimeSpan.FromHours(1);

            var start = DateTime.Now;
            var end = DateTime.Now.AddMinutes(2);
            var duration = end - start;
            Console.WriteLine("Duration: " + duration);

            // Properities

            Console.WriteLine("Minutes: " + timeSpan.Minutes);
            Console.WriteLine("Minutes: " + timeSpan.TotalMinutes);

            // Add
            Console.WriteLine("Add Example: " + timeSpan.Add(TimeSpan.FromMinutes(8)));
            Console.WriteLine("Add Example: " + timeSpan.Subtract(TimeSpan.FromMinutes(2)));

            //ToString
            Console.WriteLine("ToString: " + timeSpan.ToString());

            // Parse
            Console.WriteLine("Parse: " + TimeSpan.Parse("01:02:03"));
        }
    }
}
