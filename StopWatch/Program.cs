using System;
using System.Diagnostics;
using System.Threading;
class Program
{
    static void Main()
    {
        int i;
        // Create new stopwatch
        Stopwatch stopwatch = new Stopwatch();
        // Begin timing
        stopwatch.Start();
        for ( i = 0; i < 10; i++)
        {
            Console.WriteLine("HI");
        }
        // Stop timing
        stopwatch.Stop();
        Console.WriteLine("Time Elapsed : {0}",stopwatch.Elapsed);
        Console.ReadLine();
    }
}
