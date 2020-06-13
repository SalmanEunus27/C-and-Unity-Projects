using System;

namespace IntegerDataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            int totalSecondsPlayed = 250;
            const int secondsPerMinute = 60;
            int minutesPlayed = totalSecondsPlayed / 60;
            Console.WriteLine("Minutes Played: "+minutesPlayed);
            int secondsPlayed = totalSecondsPlayed % secondsPerMinute;
            Console.WriteLine("Seconds Played: " + secondsPlayed);

        }
    }
}
