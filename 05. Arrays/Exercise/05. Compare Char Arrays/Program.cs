using System;
using System.Linq;

namespace _05._Compare_Char_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] firstSeriesOfChars = Console.ReadLine().Split(' ').Select(char.Parse).ToArray();
            char[] secondSeriesOfChars = Console.ReadLine().Split(' ').Select(char.Parse).ToArray();
            bool isFound = true;

            for (int i = 0; i < Math.Min(firstSeriesOfChars.Length,secondSeriesOfChars.Length); i++)
            {
                if (firstSeriesOfChars[i]<secondSeriesOfChars[i])
                {
                    isFound = true;
                    break;
                }
                else if (firstSeriesOfChars[i] > secondSeriesOfChars[i])
                {
                    isFound = false;
                    break;
                }
                if (i== Math.Min(firstSeriesOfChars.Length, secondSeriesOfChars.Length)-1)
                {
                    if (firstSeriesOfChars.Length < secondSeriesOfChars.Length)
                    {
                        isFound = true;
                        break;
                    }
                    else
                    {
                        isFound = false;
                        break;
                    }
                }
            }
			
            if (isFound)
            {
                Console.WriteLine(firstSeriesOfChars);
                Console.WriteLine(secondSeriesOfChars);
            }
            else
            {
                Console.WriteLine(secondSeriesOfChars);
                Console.WriteLine(firstSeriesOfChars);
            }
        }
    }
}
