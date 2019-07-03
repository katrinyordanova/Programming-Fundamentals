using System;

namespace _09._Multiply_Evens_by_Odds
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = Math.Abs(int.Parse(Console.ReadLine()));
            int oddSum = SumOfOddDigits(input);
            int evenSum = SumOfEvenDigits(input);
            int total = oddSum * evenSum;
            Console.WriteLine(total);
        }
		
        static int SumOfOddDigits(int input)
        {
            int lastDigit = 0;
            int sum = 0;

            while (input>0)
            {
                lastDigit = input % 10;
                if (lastDigit%2!=0)
                {
                    sum += lastDigit;
                }
                input /= 10;
            }
            return sum;
        }
		
        static int SumOfEvenDigits(int input)
        {
            int residue = 0;
            int sum = 0;

            while (input > 0)
            {
                residue = input % 10;
                if (residue % 2 == 0)
                {
                    sum += residue;
                }
                input /= 10;
            }
            return sum;
        }
    }
}
