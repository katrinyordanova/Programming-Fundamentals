using System;

namespace _13.Game_of_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int magicNumber = int.Parse(Console.ReadLine());
            int counter = 0;

            for (int a = secondNumber; a >= firstNumber; a--)
            {
                for (int b = secondNumber; b >= firstNumber; b--)
                {
                    
                    if (a+b==magicNumber)
                    {
                        Console.WriteLine($"Number found! {a} + {b} = {magicNumber}");
                        return;
                    }
                    counter++;
                }
            }
            Console.WriteLine($"{counter} combinations - neither equals {magicNumber}");
        }
    }
}
