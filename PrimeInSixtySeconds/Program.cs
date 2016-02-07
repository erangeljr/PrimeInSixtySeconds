/*
    Eddie Rangel | Get the highest Prime in 60 Seconds
*/

using System;
using System.Diagnostics;

namespace PrimeInSixtySeconds
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Calculating highest Prime in 60 seconds...");
            SixtySecondsStartsNow();
            System.Console.Read();
        }

        static void SixtySecondsStartsNow()
        {
            Stopwatch timer = new Stopwatch();
            var max = 0;

            timer.Start();
            for (int i = 0; timer.Elapsed.Minutes < 1; i++)
            {                
                if (CheckPrime(i))
                {
                    max = i;
                    //System.Console.ForegroundColor = ConsoleColor.Green;
                    //System.Console.WriteLine("Prime: {0}",max);
                }
                //System.Console.ForegroundColor = ConsoleColor.Gray;
                //System.Console.WriteLine("{0} seconds", timer.Elapsed.Seconds);                
            }
            timer.Stop();
            System.Console.WriteLine("The highest prime number I calculated in 60 seconds is: {0}", max);
        }

        static bool CheckPrime(int number)
        {
            var lowerBound = Math.Floor(Math.Sqrt(number));

            if (number == 1)
                return false;
            if (number == 2)
                return true;

            for (int i = 2; i <= lowerBound; i++)
            {
                //System.Console.WriteLine("Number: {0}, LowerBound: {1}", i, lowerBound);
                if (number % i == 0) return false;
            }

            return true;

        }
    }
}
