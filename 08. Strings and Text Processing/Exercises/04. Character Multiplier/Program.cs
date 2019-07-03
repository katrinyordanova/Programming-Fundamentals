using System;
using System.Linq;
using System.Collections.Generic;

namespace _04._Character_Multiplier
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine().Split().ToList();

            string firstString = input[0];
            string secondString = input[1];

            int sum = 0;

            for (int i = 0; i < Math.Min(firstString.Length,secondString.Length); i++)
            {
                sum += firstString[i] * secondString[i];
            }

            for (int i = Math.Min(firstString.Length, secondString.Length); i < Math.Max(firstString.Length, secondString.Length); i++)
            {
                try
                {
                    sum += firstString[i];
                }
                catch 
                {
                    sum += secondString[i];
                }
            }
			
            Console.WriteLine(sum);
        }
    }
}
