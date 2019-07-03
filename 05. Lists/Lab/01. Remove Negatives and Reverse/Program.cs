using System;
using System.Collections.Generic;
using System.Linq;

namespace Lists___Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();
            List<int> positiveNumbers = new List<int>();

            foreach (var number in numbers)
            {
                if (number>0)
                {
                    positiveNumbers.Add(number);
                }
            }

            foreach (var number in numbers)
            {
                if (number < 0)
                {
                    positiveNumbers.Remove(number);
                }
            }

            positiveNumbers.Reverse();

            if (positiveNumbers.Any())
            {
                Console.Write(string.Join(" ", positiveNumbers));
            }
            else
            {
                Console.WriteLine("empty");
            }
        }
    }
}
