using System;
using System.Linq;

namespace Get_Ready_
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            var nums = new long[firstNumber];
            nums[0] = 1;
			
            for (int i = 1; i < firstNumber; i++)
            {
                long sum = 0;
                for (int prev = i - secondNumber; prev <= i - 1; prev++)
                    if (prev >= 0)
                        sum += nums[prev];
                nums[i] = sum;
            }
			
            for (int i = 0; i < firstNumber; i++)
                Console.Write(nums[i] + " ");
			
            Console.WriteLine();
        }
    }
}
