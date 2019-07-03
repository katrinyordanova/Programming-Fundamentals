using System;
using System.Linq;
using System.Collections.Generic;
namespace _04._Largest_3_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            if (numbers.Count>3)
            {
                Console.Write(string.Join(" ",numbers.OrderByDescending(x => x).Take(3)));
            }
            else
            {
                Console.WriteLine(string.Join(" ",numbers.OrderByDescending(x=>x)));
            }
        }
    }
}
