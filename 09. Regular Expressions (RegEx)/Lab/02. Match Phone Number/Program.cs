using System;
using System.Text.RegularExpressions;
using System.Linq;

namespace _02._Match_Phone_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            string phonenumers = Console.ReadLine();
            string regex = @"\+359( |-)2\1\d{3}\1\d{4}\b";
            MatchCollection matches = Regex.Matches(phonenumers, regex);

            string[] machedNumbers = matches
                .Cast<Match>()
                .Select(x => x.Value.Trim())
                .ToArray();

            Console.WriteLine(string.Join(", ", machedNumbers));
        }
    }
}
