using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace _05._Match_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string regex = @"(^|(?<=\s))-?\d+(\.\d+)?($|(?=\s))";
            MatchCollection matches = Regex.Matches(input, regex);

            foreach (Match numbers in matches)
            {
                Console.Write(numbers.Value + " ");
            }
        }
    }
}
