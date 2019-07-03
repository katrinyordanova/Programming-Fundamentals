using System;
using System.Linq;

namespace _11._Equal_Sums
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int leftSide = 0;
            int rigthSide = 0;

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    leftSide += array[i];
                }
                for (int k = i+1; k < array.Length; k++)
                {
                    rigthSide += array[k];
                }
                if (rigthSide==leftSide)
                {
                    Console.WriteLine(i);
                    return;
                }
            }
			
            Console.WriteLine("no");
        }
    }
}
