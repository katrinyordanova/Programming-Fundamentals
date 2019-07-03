using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Palindromes
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(new char[] { ' ', '.', ',', '?', '!' }, StringSplitOptions.RemoveEmptyEntries);
            List<string> text = new List<string>();

            foreach (var palindromes in input)
            {
                if (palindromes.SequenceEqual(palindromes.Reverse()))
                {
                    text.Add(palindromes);
                }
            }
			
            Console.WriteLine(string.Join(", ", text.OrderBy(x => x).Distinct()));
        }
    }
}
