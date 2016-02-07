using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimInSixtySeconds
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch timer = new Stopwatch();
            TimeSpan running = new TimeSpan();

            var sixtySeconds = 60;

            timer.Start();
            for (int i = 0; running.Minutes < 1;i++)
            {
                System.Console.WriteLine("number: {0}", i);
                running = timer.Elapsed;
            }
            timer.Stop();
            System.Console.Read();
        }
    }
}
