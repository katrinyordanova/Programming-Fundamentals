using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Sum_Adjacent_Equal_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<decimal> numbers = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(decimal.Parse)
                .ToList();

            for (int i = 1; i < numbers.Count; i++)
            {
                if (numbers[i]==numbers[i-1])
                {
                    numbers[i] += numbers[i - 1];
                    numbers.Remove(numbers[i - 1]);
                    i = 0;
                }
            }
			
            Console.Write(string.Join(" ", numbers));
        }
    }
}
