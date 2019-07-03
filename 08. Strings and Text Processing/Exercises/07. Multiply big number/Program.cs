using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
namespace _07
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstNumber = Console.ReadLine();
            int secondNumber = int.Parse(Console.ReadLine());

            if (secondNumber == 0)
            {
                Console.WriteLine('0');
                return;
            }

            int multiplyer = 0;
            int reminder = 0;
            int number = 0;
            StringBuilder stringBuilder = new StringBuilder();

            for (int i = firstNumber.Length - 1; i >= 0; i--)
            {
                multiplyer = (firstNumber[i] - 48) * secondNumber + reminder;
                number = multiplyer % 10;

                if (multiplyer > 9)
                {
                    reminder = multiplyer / 10;
                }
                else
                {
                    reminder = 0;
                }

                stringBuilder.Append(number);
            }

            if (reminder > 0)
            {
                stringBuilder.Append(reminder);
            }

            Console.WriteLine(stringBuilder.ToString().TrimEnd('0').ToCharArray().Reverse().ToArray());
        }
    }
}
