using System;

namespace _12._Test_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int maxBoundary = int.Parse(Console.ReadLine());
            int counter = 0;
            int totalSum = 0;

            for (int a = firstNumber; a >= 1; a--)
            {
                for (int b = 1; b <= secondNumber; b++)
                {
                    totalSum += a * b * 3;
                    counter++;
                    if (totalSum>=maxBoundary)
                    {
                        Console.WriteLine($"{counter} combinations");
                        Console.WriteLine($"Sum: {totalSum} >= {maxBoundary}");
                        return;
                    }
                }
            }
            if (maxBoundary>=totalSum)
            {
                Console.WriteLine($"{counter} combinations");
                Console.WriteLine($"Sum: {totalSum}");
            }
        }
    }
}


