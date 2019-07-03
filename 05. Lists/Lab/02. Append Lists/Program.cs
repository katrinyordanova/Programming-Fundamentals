using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Append_Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine()
                .Split('|')
                .ToList();

            input.Reverse();

            foreach (var item in input)
            {
                List<int> numbers = item.Split(new char[] { ' ' },StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();

                foreach (var number in numbers)
                {
                    Console.Write($"{number} ");
                }
            }
            
        }
    }
}
