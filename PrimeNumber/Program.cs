using System;
namespace PrimeNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, i;
            Console.Write("Enter a Number : ");
            n = int.Parse(Console.ReadLine());

            for (i = 2; i < n / 2; i++)
            {
                if (n % i == 0)
                {
                    Console.Write("Number is not Prime.");
                }
                else
                {
                    Console.Write("Number is Prime.");
                }
            } 
        }
    }
}