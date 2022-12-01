
using System;
namespace FibonacciSeries
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0, b = 1, c, i, n;
            Console.WriteLine("Enter number of terms:");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("Fibonacci series:");
            Console.Write("{0} {1} ", a, b);
            for (i = 2; i < n; i++)
            {
                c = a + b;
                Console.Write("{0} ",c);
                a = b;
                b = c;
            }
        }
    }
}