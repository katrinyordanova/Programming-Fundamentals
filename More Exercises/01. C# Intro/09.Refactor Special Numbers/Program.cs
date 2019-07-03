using System;

namespace _09.Refactor_Special_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());
            int total = 0;
            int number = 0;
            bool notSpecial = false;

            for (int i = 1; i <= length; i++)
            {
                number = i;

                while (i > 0)
                {
                    total += i % 10;
                    i = i / 10;
                }

                notSpecial = (total == 5) || (total == 7) || (total == 11);
                Console.WriteLine($"{number} -> {notSpecial}");
                total = 0;
                i = number;
            }
        }
    }
}
