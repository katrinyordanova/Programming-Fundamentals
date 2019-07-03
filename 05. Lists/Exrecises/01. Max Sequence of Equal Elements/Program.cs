using System;
using System.Linq;
using System.Collections.Generic;

namespace _01._Max_Sequence_of_Equal_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();
            int counter = 0;
            int maxCounter = 0;
            int numberMax = 0;

            for (int i = 0; i < numbers.Count-1; i++)
            {
                if (numbers[i]==numbers[i+1])
                {
                    counter++;
                    if (counter>maxCounter)
                    {
                        maxCounter = counter;
                        numberMax = numbers[i];
                    }
                }
                else
                {
                    counter = 1;
                }
                if (counter > maxCounter)
                {
                    maxCounter = counter;
                    numberMax = numbers[i];
                }
            }

            for (int i = 0; i < maxCounter; i++)
            {
                Console.Write(numberMax+ " ");
            }
        }
    }
}
