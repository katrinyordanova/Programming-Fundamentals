using System;
using System.Collections.Generic;

namespace _02._Count_Substring_Occurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine().ToLower();
            string word = Console.ReadLine().ToLower();
            int counter = 0;
            int index = 0;

            while (true)
            {
                index = input.IndexOf(word, index);

                if (index>=0)
                {
                    counter++;
                    index++;                                   
                }
                else
                {
                    break;
                }
            }
			
            Console.WriteLine(counter);
        }
    }
}
