using System;

namespace _11._Odd_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                int oddNumber = Math.Abs(int.Parse(Console.ReadLine()));

                if (oddNumber % 2==0)
                {
                    Console.WriteLine("Please write an odd number.");
                }
                else
                {
                    Console.WriteLine($"The number is: {oddNumber}");
                    break;
                }
            }
        }
    }
}
