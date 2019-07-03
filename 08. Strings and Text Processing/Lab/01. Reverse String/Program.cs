using System;

namespace _01._Reverse_String
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            char[] array = input.ToCharArray();
            Array.Reverse(array);

            Console.WriteLine(array);
        }
    }
}
