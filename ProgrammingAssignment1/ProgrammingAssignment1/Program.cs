using System;

namespace ProgrammingAssignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---This is an apllication to calculate the distance between two points and the angle between two points---");
            Console.WriteLine("Enter first x value: ");
            float x1 = float.Parse(Console.ReadLine());
            float y1 = float.Parse(Console.ReadLine());
            float x2 = float.Parse(Console.ReadLine());
            float y2 = float.Parse(Console.ReadLine());
            float deltax = x2 - x1;
            float deltay = y2 - y1;
            float  c = (float) Math.Sqrt(Math.Pow(deltax, 2) + Math.Pow(deltay,2));
            Console.WriteLine("The distance between the two points is: "+c);
            float radians = (float) Math.Atan2(deltay,deltax);
            double angle = (radians * (180 / Math.PI));
            Console.WriteLine("The angle in degrees between the two points: "+angle);

        }
    }
}
