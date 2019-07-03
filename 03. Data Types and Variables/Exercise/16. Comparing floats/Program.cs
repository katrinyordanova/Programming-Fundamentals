using System;

namespace _16._Comparing_floats
{
    class Program
    {
        static void Main(string[] args)
        {
            double firstNumber = double.Parse(Console.ReadLine());
            double secondNumber = double.Parse(Console.ReadLine());

            double theBiggestOfThemAll = Math.Max(firstNumber, secondNumber);
            double theSmallestOfThemAll = Math.Min(firstNumber, secondNumber);
            double difference = theBiggestOfThemAll - theSmallestOfThemAll;

            if (difference> 0.000001)
            {
                Console.WriteLine("False");
            }
            else
            {
                Console.WriteLine("True");
            }
        }
    }
}
