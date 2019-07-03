using System;

namespace _10._Sum_of_Chars
{
    class Program
    {
        static void Main(string[] args)
        {
            byte numberOfLetters = byte.Parse(Console.ReadLine());
            int sum = 0;

            while (numberOfLetters>0)
            {
                sum += char.Parse(Console.ReadLine());
                numberOfLetters--;
            }
			
            Console.WriteLine($"The sum equals: {sum}");
        }
    }
}
