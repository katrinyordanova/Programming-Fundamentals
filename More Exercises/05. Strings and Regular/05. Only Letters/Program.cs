using System;
using System.Text.RegularExpressions;
using System.Linq;

namespace _05._Only_Letters
{
    class Program
    {
        static void Main(string[] args)
        {
            string jibberish = Console.ReadLine();
            string regex = @"(?<digits>[0-9]+)(?<letters>[A-Za-z])";

            MatchCollection matches = Regex.Matches(jibberish, regex);

            foreach (Match match in matches)
            {
                jibberish = jibberish.Replace(match.Groups["digits"].Value, match.Groups["letters"].Value);
            }
            Console.WriteLine(jibberish);
        }
    }
}
