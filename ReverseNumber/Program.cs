using System;

namespace ReverseNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int Num, Rev, rem;
            Console.WriteLine("Enter a No. to reverse: ");
            Num = int.Parse(Console.ReadLine());
            Rev = 0;
            while (Num > 0)
            {
                rem = Num % 10;
                Rev = (Rev * 10) + rem;
                Num = Num / 10;
            }
            Console.WriteLine("Reverse No. is {0}", Rev);
            Console.ReadLine();
        }
    }
}