using System;

namespace _09.Multiplication_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            int multiplyBy = int.Parse(Console.ReadLine());
            int multiplyMe = int.Parse(Console.ReadLine());

            if (multiplyMe>10)
            {
                Console.WriteLine($"{multiplyBy} X {multiplyMe} = {multiplyMe * multiplyBy}");
            }

            for (int i = multiplyMe; i <= 10; i++)
            {
                Console.WriteLine($"{multiplyBy} X {i} = {multiplyBy*i}");
            }
        }
    }
}
