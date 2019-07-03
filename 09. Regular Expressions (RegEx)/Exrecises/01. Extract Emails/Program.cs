using System;
using System.Text.RegularExpressions;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string regex = @"(^|(?<=\s))([a-z0-9])+(([_\.-]?[a-z0-9])*)@([a-z]+)([.-][a-z]+)*\.([a-z]+)([.-][a-z]+)*";
            MatchCollection matches = Regex.Matches(input, regex);

            foreach (Match match in matches)
            {
                Console.WriteLine(match.Value);
            }
        }
    }
}

