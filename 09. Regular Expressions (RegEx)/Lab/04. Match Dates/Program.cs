using System;
using System.Text.RegularExpressions;
using System.Linq;

namespace _04._Match_Dates
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string regex = @"\b(?<day>\d{2})(\/|.|-)(?<month>[A-Z][a-z]{2})(\1)(?<year>\d{4})";
            MatchCollection matches = Regex.Matches(input, regex);

            foreach (Match match in matches)
            {
                string day = match.Groups["day"].Value;
                string month = match.Groups["month"].Value;
                string year = match.Groups["year"].Value;

                Console.WriteLine($"Day: {day}, Month: {month}, Year: {year}");
            }
        }
    }
}
