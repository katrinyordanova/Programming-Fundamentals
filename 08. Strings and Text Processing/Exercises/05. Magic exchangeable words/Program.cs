using System;
using System.Linq;

namespace _05._Magic_exchangeable_words
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            string firstWord = input[0];
            string secondWord = input[1];

            int wordFirst = firstWord.ToCharArray().Distinct().Count();
            int wordSecond = secondWord.ToCharArray().Distinct().Count();

            if (wordFirst==wordSecond)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }
        }
    }
}
