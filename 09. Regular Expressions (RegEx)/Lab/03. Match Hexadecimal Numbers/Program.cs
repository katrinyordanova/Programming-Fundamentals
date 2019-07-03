using System;
using System.Text.RegularExpressions;
using System.Linq;

namespace _03._Match_Hexadecimal_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string regex = @"(\b((((0x)([A-F]|[0-9])+)))\b)|\b((((0x)|([A-F]|[0-9])+)))\b";
            //or: \b(0x:?)?[A-F0-9]+\b;
            var match = Regex.Matches(input, regex)
            .Cast<Match>()
            .Select(x => x.Value)
            .ToArray();

            Console.WriteLine(string.Join(" ", match));
        }
    }
}
