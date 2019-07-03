using System;

namespace _04._Beverage_Labels
{
    class Program
    {
        static void Main(string[] args)
        {
            string nameOfTheDrink = Console.ReadLine();
            int volumeOfTheDrink = int.Parse(Console.ReadLine());
            int energyContentOfTheDrink = int.Parse(Console.ReadLine());
            int sugarContentOfTheDrink = int.Parse(Console.ReadLine());
               
            double energyContentPerDrink = (volumeOfTheDrink * energyContentOfTheDrink) / 100.00;
            double sugarContentPerDrink = (volumeOfTheDrink * sugarContentOfTheDrink) / 100.00;

            Console.WriteLine($"{volumeOfTheDrink}ml {nameOfTheDrink}: "); 
            Console.WriteLine($"{energyContentPerDrink}kcal, {sugarContentPerDrink}g sugars");
        }
    }
}
