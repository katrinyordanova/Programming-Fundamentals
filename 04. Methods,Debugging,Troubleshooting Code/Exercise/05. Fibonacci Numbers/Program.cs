using System;

namespace _05._Fibonacci_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
			
            if (number==0)
            {
                Console.WriteLine(1);
            }
            else
            {
                Console.WriteLine(GetFibonacciNumbers(number));
            }
        }
		
        static int GetFibonacciNumbers(int number)
        {
            int firstNumber = 0;
            int secondNumber = 1;
            int thirdNumber = 0;

            for (int i = 1; i <= number; i++)
            {
                thirdNumber = firstNumber + secondNumber;
                firstNumber = secondNumber;
                secondNumber = thirdNumber;
            }
            return thirdNumber;
        }
    }
}
