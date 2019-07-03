using System;

namespace _17._Print_Part_Of_ASCII_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());

            char convertStart = Convert.ToChar(start);
            char convertEnd = Convert.ToChar(end);

            for (char i = convertStart; i <= convertEnd; i++)
            {
                Console.Write(i + " ");
            }
        }
    }
}
