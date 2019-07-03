using System;

namespace _06._Prime_Checker
{
    class Program
    {
        static void Main(string[] args)
        {
            long input = long.Parse(Console.ReadLine());
            if (IsPrime(input))
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }

            bool IsPrime(long number)
            {
                if (number == 1) return false;
                if (number == 2) return true;
                if (number % 2 == 0) return false;

                var boundary = (int)Math.Floor(Math.Sqrt(number));

                for (int i = 3; i <= boundary; i += 2)
                {
                    if (number % i == 0) return false;
                }

                return true;
            }
        }
    }
}
