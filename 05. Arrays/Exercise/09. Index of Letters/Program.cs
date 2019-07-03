using System;
using System.Linq;

namespace _09._Index_of_Letters
{
    class Program
    {
        static void Main(string[] args)
        {
            string letters = Console.ReadLine();
            char[] array = new char[26];

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = (char)(97 + i);
            }
            for (int j = 0; j < letters.Length; j++)
            {
                Console.WriteLine(letters[j] + " -> " + Array.IndexOf(array,letters[j]));
            }
        }
    }
}
