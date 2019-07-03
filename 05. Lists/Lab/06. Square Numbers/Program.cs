using System;
using System.Linq;
using System.Collections.Generic;

namespace _06._Square_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
            List<int> squareNumbers = new List<int>();

            numbers.Sort();
            numbers.Reverse();

            foreach (var number in numbers)
            {               
                if (Math.Sqrt(number) == Math.Truncate(Math.Sqrt(number)))
                {
                    squareNumbers.Add(number);
                }
            }
			
            Console.WriteLine(string.Join(" ", squareNumbers));
        }
    }
}
