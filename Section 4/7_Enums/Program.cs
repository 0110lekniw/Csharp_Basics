

using System;

namespace _7_Enums
{
    public enum ShippingMethod
    {
        RegularAirMail = 1,
        RegisteredAirMail = 2,
        Express = 3
    }

    class Program
    {
        static void Main(string[] args)
        {
            var method = ShippingMethod.Express;
            System.Console.WriteLine((int)method);

            var methodId = 3;
            System.Console.WriteLine((ShippingMethod)method);

            System.Console.WriteLine(method.ToString());

            var methodName = "Express";

            //parsing - convert string to diffrent type
            var shippingMethod = (ShippingMethod)Enum.Parse(typeof(ShippingMethod), methodName);
            Console.WriteLine(shippingMethod);


        }
    }
}
