using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Special_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());

            for (int i = 1; i <= input; i++)
            {
                int number = i;
                int sum = 0;

                while (number>0)
                {
                    int lastDigit = number % 10;
                    sum += lastDigit;
                    number /= 10;
                }

                bool isSpecial = sum == 5 || sum == 7 || sum == 11;

                Console.WriteLine($"{i} -> {isSpecial}");
            }
        }
    }
}
