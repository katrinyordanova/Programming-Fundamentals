using System;

namespace _02._Sign_of_Integer_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            TypeOfNumber(input);

        }
        static int TypeOfNumber(int input)
        {
            if (input>0)
            {
                Console.WriteLine($"The number {input} is positive.");
            }           
            else if (input<0)
            {
                Console.WriteLine($"The number {input} is negative.");
            }
            else
            {
                Console.WriteLine($"The number {input} is zero.");
            }
            return input;
        }
    }
}
