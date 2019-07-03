using System;
using System.Linq;

namespace _04._Grab_and_Go
{
    class Program
    {
        static void Main(string[] args)
        {
            long[] numbers = Console.ReadLine()
                .Split(new char[] { ' ' },StringSplitOptions.RemoveEmptyEntries)
                .Select(long.Parse)
                .ToArray();
            long number = long.Parse(Console.ReadLine());

            if (numbers.Contains(number))
            {
                int value = 0;

                for (int i = 0; i < numbers.Length; i++)
                {
                    if (numbers[i]==number)
                    {
                        value = i;
                    }
                }
                Console.WriteLine(numbers.Take(value).Sum());
            }
            else
            {
                Console.WriteLine("No occurrences were found!");
            }
        }
    }
}
