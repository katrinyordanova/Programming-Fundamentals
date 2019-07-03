using System;
using System.Linq;

namespace _06._Max_Sequence_of_Equal_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            long[] numbers = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(long.Parse)
                .ToArray();
            long start = 0;
            long length = 0;
            long bestStart = 0;
            long bestLength = 0;

            for (long i = 1; i < numbers.Length; i++)
            {
                if (numbers[i]==numbers[start])
                {
                    length++;
                    if (length>bestLength)
                    {
                        bestLength = length;
                        bestStart = start;
                    }
                }
                else
                {
                    start++;
                    i = start;
                    length = 0;
                }
            }
			
            for (int i = 0; i <= bestLength; i++)
            {
                Console.Write(numbers[bestStart + i] + " ");
            }
        }
    }
}
