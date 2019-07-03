using System;

namespace _07._Exchange_Variable_Values
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = 5;
            int secondNumber = 10;

            Console.WriteLine("Before:");
            Console.WriteLine($"a = {firstNumber}");
            Console.WriteLine($"b = {secondNumber}");
            Console.WriteLine("After:");
            Console.WriteLine($"a = {secondNumber}");
            Console.WriteLine($"b = {firstNumber}");
        }
    }
}
