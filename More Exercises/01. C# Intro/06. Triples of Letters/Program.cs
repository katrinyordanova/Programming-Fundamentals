using System;

namespace _06._Triples_of_Letters
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfLetters = int.Parse(Console.ReadLine());

            for (char a = 'a'; a < 'a' + numberOfLetters; a++)
            {
                for (char b = 'a'; b < 'a' + numberOfLetters; b++)
                {
                    for (char c = 'a'; c < 'a' + numberOfLetters; c++)
                    {
                        Console.WriteLine($"{a}{b}{c}");
                    }
                }
            }
        }
    }
}
