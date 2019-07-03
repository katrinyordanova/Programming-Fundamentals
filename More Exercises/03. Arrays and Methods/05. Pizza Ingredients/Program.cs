using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Pizza_Ingredients
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            int number = int.Parse(Console.ReadLine());
            List<string> ingredients = new List<string>();
            int counter = 0;

            for (int i = 0; i < input.Length && counter < 10; i++)
            {
                if (input[i].Length == number)
                {
                    ingredients.Add(input[i]);
                    counter++;
                    Console.WriteLine($"Adding {input[i]}.");
                }
            }
            
			Console.WriteLine($"Made pizza with total of {counter} ingredients.");
            Console.WriteLine($"The ingredients are: {string.Join(", ", ingredients)}.");
        }
    }
}
