using System;

namespace _03._Printing_Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            PrintTriangle(input);
        }
		
        static void PrintLine(int start, int end)
        {
            for (int i = start; i <= end; i++)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }
		
        static void PrintTriangle(int input)
        {
            for (int row = 1; row <= input; row++)
            {
                PrintLine(1, row);
            }
            for (int col = input - 1; col >= 1; col--)
            {
                PrintLine(1, col);
            }
        }
    }
}
