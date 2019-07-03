using System;

namespace _03._Unicode_Characters
{
    class Program
    {
        static void Main(string[] args)
        {
            string symbols = Console.ReadLine();

            foreach (var symbol in symbols)
            {
                Console.Write("\\u{0:x4}", (int)symbol);
            }
        }
    }
}
