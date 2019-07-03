using System;
using System.Linq;

namespace _04._Triple_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int sum = 0;
            bool notFound = true;

            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = i+1; j < numbers.Length; j++)
                {
                    sum = numbers[i] + numbers[j];

                    if (numbers.Contains(sum))
                    {
                        Console.WriteLine($"{numbers[i]} + {numbers[j]} == {sum}");
                        if (notFound)
                        {
                            notFound = false;
                        }
                    }
                    
                }

            }
			
            if (notFound)
            {
                Console.WriteLine("No");
            }
        }
    }
}
