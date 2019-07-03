using System;

namespace _07.__Primes_in_Given_Range
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());
            double result1 = DistanceFromCenter(x1, y1);
            double result2 = DistanceFromCenter(x2, y2);

            if (result1 > result2)
            {
                PrintPoint(x2, y2);
                Console.WriteLine();
            }
            else if (result2 > result1)
            {
                PrintPoint(x1, y1);
                Console.WriteLine();
            }
            else
            {
                PrintPoint(x1, y1);
                Console.Write(" ");
                PrintPoint(x2, y2);
                Console.WriteLine();
            }
        }

        private static void PrintPoint(double x, double y)
        {
            Console.Write($"({x}, {y})");
        }

        private static double DistanceFromCenter(double x, double y)
        {
            var distance = x * x + y * y;

            return distance;
        }
    }
}
