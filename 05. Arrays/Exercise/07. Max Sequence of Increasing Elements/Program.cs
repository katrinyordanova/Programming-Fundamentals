using System;
using System.Linq;

namespace _07._Max_Sequence_of_Increasing_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int curentStart = 0;
            int curentLength = 1;
            int maxStart = 0;
            int maxLength = 1;

            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i]>numbers[i-1])
                {
                    curentLength++;
                    if (curentLength>maxLength)
                    {
                        maxLength = curentLength;
                        maxStart = curentStart;
                    }
                }
                else
                {
                    curentStart = i;
                    curentLength = 1;
                }
            }
			
            for (int j = maxStart; j <= maxStart+maxLength; j++)
            {
                Console.Write($"{numbers[j]} ");
            }
        }
    }
}
