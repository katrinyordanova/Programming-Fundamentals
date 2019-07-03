using System;
using System.Linq;

namespace _09._Extract_Middle_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            if (array.Length == 1)
            {
                Console.Write($"{{ {array[0]} }}");
                return;
            }

            else if (array.Length % 2 == 0)
            {
                Console.Write($"{{ {array[array.Length / 2 - 1]}, {array[array.Length / 2]} }}");
            }

            else
            {
                Console.Write($"{{ {array[array.Length / 2 - 1]}, {array[array.Length / 2]}, {array[array.Length / 2 + 1]} }}");
            }

        }
    }
}

