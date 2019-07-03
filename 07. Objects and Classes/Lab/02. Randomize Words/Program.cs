using System;
using System.Linq;
using System.Collections.Generic;

namespace _02._Randomize_Words
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] sentence = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            Random random = new Random();

            for (int i = 0; i < sentence.Length; i++)
            {
                int firstWord = random.Next(0, sentence.Length);
                int secondWord = random.Next(0, sentence.Length);

                string changer = sentence[firstWord];
                sentence[firstWord] = sentence[secondWord];
                sentence[secondWord] = changer;
            }
			
            Console.WriteLine(string.Join("\n",sentence));
        }
    }
}
