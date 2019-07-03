using System;
using System.Text.RegularExpressions;
using System.Linq;

namespace _06._Replace_a_Tag
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            while (input!="end")
            {
                string regex = @"<a.*?href.?=(.*)>(.*?)<\/a>";
                string replacement= @"[URL href=$1]$2[/URL]";
                string result = Regex.Replace(input,regex,replacement);

                Console.WriteLine(result);

                input = Console.ReadLine();
            }
        }
    }
}
