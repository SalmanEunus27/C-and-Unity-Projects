using System;

namespace FloatingPointDataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            int score = 1960;
            int totalSecondsPlayed = 10000;
           

            float pointsPerSecond = (float)score / totalSecondsPlayed;
            Console.WriteLine("Points Per Second: " + pointsPerSecond);
        }
    }
}
