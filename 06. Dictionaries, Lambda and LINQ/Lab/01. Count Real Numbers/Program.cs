using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Count_Real_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> numbers = Console.ReadLine()
                .Split(' ')
                .Select(double.Parse)
                .ToList();
            SortedDictionary<double, int> newDictionary = new SortedDictionary<double, int>();

            foreach (var number in numbers)
            {
                if (newDictionary.ContainsKey(number))
                {
                    newDictionary[number]++;
                }
                else
                {
                    newDictionary[number] = 1;
                }
            }

            foreach (var keys in newDictionary.Keys)
            {
                Console.WriteLine($"{keys} -> {newDictionary[keys]}");
            }
        }
    }
}
