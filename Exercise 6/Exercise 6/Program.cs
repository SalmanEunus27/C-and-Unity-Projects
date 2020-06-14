using System;

namespace Exercise_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the angle in degrees: ");
            float angle = float.Parse(Console.ReadLine());
            float cosine = (float)Math.Cos(angle * Math.PI / 180);
            float sine = (float)Math.Sin(angle * Math.PI / 180);

            Console.WriteLine("Cosine of the angle: "+cosine);
            Console.WriteLine("sine of the angle: "+sine);

        }
    }
}
