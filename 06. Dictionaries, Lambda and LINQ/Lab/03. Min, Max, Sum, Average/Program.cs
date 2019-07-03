using System;
using System.Linq;

namespace _03._Min__Max__Sum__Average
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfNumbers=int.Parse(Console.ReadLine());
            int[] arrayNumber = new int[numberOfNumbers];

            for (int i = 0; i < numberOfNumbers; i++)
            {
                arrayNumber[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine($"Sum = {arrayNumber.Sum()}");
            Console.WriteLine($"Min = {arrayNumber.Min()}");
            Console.WriteLine($"Max = {arrayNumber.Max()}");
            Console.WriteLine($"Average = {arrayNumber.Average()}");
        }
    }
}
