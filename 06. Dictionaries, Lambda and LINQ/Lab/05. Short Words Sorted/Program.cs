using System;
using System.Linq;
using System.Collections.Generic;
namespace _05._Short_Words_Sorted
{
    class Program
    {
        static void Main(string[] args)
        {
            var separators = new char[] { '.', ',', ':', ';', '(', ')', '[', ']', '"', '\'', '\\', '/', '!', '?', ' ' };
            var wordsList = Console.ReadLine()
                .ToLower()
                .Split(separators, StringSplitOptions.RemoveEmptyEntries)
                .Distinct()
                .Where(w => w.Length < 5)
                .OrderBy(w => w)
                .ToList();
				
            Console.WriteLine(string.Join(", ", wordsList));
        }
    }
}
