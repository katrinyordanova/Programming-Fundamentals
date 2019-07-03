using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Text_Filter
{
    class Program
    {
        static void Main(string[] args)
        {
            string [] bannedWords = Console.ReadLine().Split(new char[] { ' ', ',' },StringSplitOptions.RemoveEmptyEntries).ToArray();
            string text = Console.ReadLine();            

            foreach (var bannWord in bannedWords)
            {
                if (text.Contains(bannWord))
                {
                    text = text.Replace(bannWord, new string('*', bannWord.Length));   
                }
            }
			
            Console.Write(text);
        }
    }
}
