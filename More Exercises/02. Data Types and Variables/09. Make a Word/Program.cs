using System;

namespace _09._Make_a_Word
{
    class Program
    {
        static void Main(string[] args)
        {
            byte lengthOfCharacters = byte.Parse(Console.ReadLine());
            char[] letters = new char[lengthOfCharacters];

            for (int i = 0; i < lengthOfCharacters; i++)
            {
                char newLetter = char.Parse(Console.ReadLine());
                letters[i] = newLetter;
            }

            string combinedLetters = new string(letters);
            Console.WriteLine($"The word is: {combinedLetters}");
        }
    }
}
