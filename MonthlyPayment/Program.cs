using System;

namespace Monthly_Payment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the Year: ");
            MonthlyPayment.Y = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the interest rate: ");
            MonthlyPayment.R = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the loan amount : ");
            MonthlyPayment.P = Convert.ToInt32(Console.ReadLine());

            MonthlyPayment.monthlyPayment();
        }
    }
}