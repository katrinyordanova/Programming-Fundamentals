using System;

namespace _05._Character_Stats
{
    class Program
    {
        static void Main(string[] args)
        {
            string nameOfThePlayer = Console.ReadLine();
            int currentHealth = int.Parse(Console.ReadLine());
            int maximumHealth = int.Parse(Console.ReadLine());
            int currentEnergy = int.Parse(Console.ReadLine());
            int maximumEnergy = int.Parse(Console.ReadLine());

            int realHealth=maximumHealth-currentHealth;
            int realEnergy=maximumEnergy-currentEnergy;

            Console.WriteLine($"Name: {nameOfThePlayer}");
            Console.WriteLine($"Health: |{new string('|', currentHealth)}{new string('.', realHealth)}|");
            Console.WriteLine($"Energy: |{new string('|', currentEnergy)}{new string('.', realEnergy)}|");
        }
    }
}
