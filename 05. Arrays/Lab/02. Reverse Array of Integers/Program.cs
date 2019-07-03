using System;

namespace _02._Reverse_Array_of_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());
            int[] array = new int[length];

            for (int i = 0; i < length; i++)
            {
                int numbers = int.Parse(Console.ReadLine()); 
                array[i]=numbers;
            }
            for (int j = length - 1; j >= 0; j--)
            {
                Console.WriteLine(array[j]);
            }
        }
    }
}
