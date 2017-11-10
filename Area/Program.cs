using System;

namespace Area
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is the radius of the circle to calculate the area?: ");
            string radiusString = Console.ReadLine();
            double radius = Convert.ToDouble(radiusString);
            double pi = 3.14;
            double a = pi * radius * radius;
            Console.WriteLine("The area of a circle with a radius of " + radius + " is " + a);
            Console.ReadLine();
                
        }
    }
}
