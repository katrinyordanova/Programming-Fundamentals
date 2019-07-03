using System;

namespace _11._5_Different_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());

            if ((secondNumber-firstNumber)<5)
            {
                Console.WriteLine("No");
            }
            for (int a = firstNumber; a < secondNumber; a++)
            {
                for (int b = firstNumber; b < secondNumber; b++)
                {
                    for (int c = firstNumber; c < secondNumber; c++)
                    {
                        for (int d = firstNumber; d < secondNumber; d++)
                        {
                            for (int e = firstNumber; e <= secondNumber; e++)
                            {
                                if (firstNumber<=a && a<b && b<c && c<d && d<e && e<=secondNumber)
                                {
                                    Console.WriteLine($"{a} {b} {c} {d} {e}");
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}

