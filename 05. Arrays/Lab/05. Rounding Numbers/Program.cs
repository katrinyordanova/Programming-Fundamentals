using System;
using System.Linq;

namespace _05._Rounding_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal[] numbersArray = Console.ReadLine().Split(' ').Select(decimal.Parse).ToArray();

            for (int i = 0; i < numbersArray.Length; i++)
            {
                decimal round = Math.Round(numbersArray[i], 0, MidpointRounding.AwayFromZero);
                Console.WriteLine($"{numbersArray[i]} => {round}");
            }
        }
    }
}
