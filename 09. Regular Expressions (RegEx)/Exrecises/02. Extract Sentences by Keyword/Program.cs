using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _02._Extract_Sentences_by_Keyword
{
    class Program
    {
        static void Main(string[] args)
        {
            string findWord = Console.ReadLine();
            string[] text = Console.ReadLine()
                .Split('.', '!', '?')
                .ToArray();
            List<string> foundWords = new List<string>();
            string regex = $@"\b{findWord}\b";

            foreach (var sentence in text)
            {
                if (Regex.IsMatch(sentence, regex))
                {
                    foundWords.Add(sentence.Trim());
                }
            }

            foreach (var found in foundWords)
            {
                Console.WriteLine(found);
            }

        }
    }
}
