using System;
using System.Text.RegularExpressions;

namespace _01.Censorship
{
    class Program
    {
        static void Main(string[] args)
        {
            string curseWord = Console.ReadLine();
            string [] text = Console.ReadLine().Split(' ',':',';');
            string regex = $@"{curseWord}";

            foreach (var words in text)
            {
                string replacement = new string('*', curseWord.Length);
                string matches = Regex.Replace(words, regex,replacement);

                Console.Write(matches+ " ");
            } 
        }
    }
}
