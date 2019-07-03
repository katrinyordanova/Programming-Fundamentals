using System;
using System.Linq;
using System.Collections.Generic;

namespace _04._Split_by_Word_Casing
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> words = Console.ReadLine()
                .Split(new char[] { ' ', ',', ';', '.', '(', ')', '"', '\'','/','\\','[',']','!' ,':'}, StringSplitOptions.RemoveEmptyEntries)
                .ToList();
            List<string> lowerCase = new List<string>();
            List<string> upperCase = new List<string>();
            List<string> mixedCases = new List<string>();

            foreach (var word in words)
            {
                if (word.All(char.IsLower))
                {
                    lowerCase.Add(word);
                }
                else if (word.All(char.IsUpper))
                {
                    upperCase.Add(word);
                }
                else
                {
                    mixedCases.Add(word);
                }
            }

            Console.WriteLine($"Lower-case: {string.Join(", ",lowerCase)}");
            Console.WriteLine($"Mixed-case: {string.Join(", ",mixedCases)}");
            Console.WriteLine($"Upper-case: {string.Join(", ",upperCase)}");
        }
    }
}
