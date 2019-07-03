using System;

namespace _13._Vowel_or_Digit
{
    class Program
    {
        static void Main(string[] args)
        {
            var symbol = Console.ReadLine();

            try
            {
                int.Parse(symbol);
                Console.WriteLine("digit");
            }
            catch (Exception)
            {
                char letter = char.Parse(symbol);
                bool isItAVowel = letter == 'a' ||
                    letter == 'o' ||
                    letter == 'i' ||
                    letter == 'e' ||
                    letter == 'u';

                Console.WriteLine(isItAVowel ? "vowel" : "other");
            }
        }
    }
}
