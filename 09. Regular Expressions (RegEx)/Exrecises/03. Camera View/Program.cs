using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _03._Camera_View
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int skip = numbers[0];
            int take = numbers[1];
            string text = Console.ReadLine();
            string regex = @"\|<(\w{" + skip + @"})([\w]{0," + take + @"})";

            MatchCollection matches = Regex.Matches(text, regex);
            List<string> result = new List<string>();

            foreach (Match match in matches)
            {
                result.Add(match.Groups[2].Value);
            }

            Console.WriteLine(string.Join(", ", result));
        }
    }
}
