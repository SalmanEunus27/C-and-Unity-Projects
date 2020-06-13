using System;

namespace Exercise4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter First Altitude: ");
            int firstAltitude = int.Parse(Console.ReadLine());
            Console.Write("Enter second Altitude: ");
            int secondAltitude = int.Parse(Console.ReadLine());
            int altitudeCovered = firstAltitude - secondAltitude;
            Console.WriteLine("Distance Covered: "+altitudeCovered);
        }
    }
}
