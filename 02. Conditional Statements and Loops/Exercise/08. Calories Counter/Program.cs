using System;

namespace _08._Calories_Counter
{
    class Program
    {
        static void Main(string[] args)
        {
            int totalIngredients = int.Parse(Console.ReadLine());
            int calories = 0;

            for (int i = 0; i < totalIngredients; i++)
            {
                string ingredient = Console.ReadLine().ToLower();
                if (ingredient == "cheese")
                {
                    calories += 500;
                }
                if (ingredient=="tomato sauce")
                {
                    calories += 150;
                }
                if (ingredient == "salami")
                {
                    calories += 600;
                }
                if (ingredient == "pepper")
                {
                    calories += 50;
                }
            }
            Console.WriteLine($"Total calories: {calories}");
        }
    }
}
