using System;

namespace activity6
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Input distance (meters): ");
            int distance = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input time (hour): ");
            int hours = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input time(minutes): ");
            int minutes = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input time(seconds): ");
            int seconds = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Your speed in meters / sec is {0}", distance / );
            Console.WriteLine("Your speed in km / h is {0}", distance / );
            Console.WriteLine("Your speed in miles / h is {0}", distance / );

        }
    }
}
