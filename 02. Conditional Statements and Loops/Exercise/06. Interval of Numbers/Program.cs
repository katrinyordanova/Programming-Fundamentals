using System;

namespace _06.Interval_of_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int smallerNumber = Math.Min(firstNumber, secondNumber);
            int biggerNumber = Math.Max(firstNumber, secondNumber);

            for (int i = smallerNumber; i <= biggerNumber; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
