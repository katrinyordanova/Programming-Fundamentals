using System;
using System.Linq;
using System.Collections.Generic;

namespace _06._Sum_Reversed_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            int sum = 0;

            for (int i = 0; i < numbers.Count; i++)
            {
                List<char> newNumbers = numbers[i]
                .ToString()
                .ToList();

                newNumbers.Reverse();

                sum += int.Parse(string.Join("", newNumbers));
            }
			
            Console.Write(sum);  
        }
    }
}
