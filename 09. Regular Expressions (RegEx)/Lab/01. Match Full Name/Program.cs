using System;
using System.Text.RegularExpressions;

namespace _01._Match_Full_Name
{
    class Program
    {
        static void Main(string[] args)
        {
            string names = Console.ReadLine();

            string regex = @"\b[A-Z][a-z]+ [A-Z][a-z]+\b";

            MatchCollection matchedNames = Regex.Matches(names, regex);

            foreach (Match name in matchedNames)
            {
                Console.Write(name.Value + " ");
            }
			
            Console.WriteLine();
        }
    }
}
