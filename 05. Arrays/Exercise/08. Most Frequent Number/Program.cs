using System;
using System.Linq;

namespace _08._Most_Frequent_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] counters = new int[numbers.Length];
            int counterMax = 0;
            int numberMax = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = 0; j < numbers.Length; j++)
                {
                    if (numbers[i]==numbers[j])
                    {
                        counters[i]++;
                        if (counters[i]>counterMax)
                        {
                            counterMax = counters[i];
                            numberMax = numbers[i];
                        }
                    }
                }
            }
            Console.WriteLine(numberMax);
        }
    }
}
