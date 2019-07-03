using System;

namespace _06._Theatre_Promotion
{
    class Program
    {
        static void Main(string[] args)
        {
            string typeOfDay = Console.ReadLine().ToLower();
            int age = int.Parse(Console.ReadLine());

            if (age < 0 || age > 122)
            {
                Console.WriteLine("Error!");
                return;
            }
            else if (0<=age && age <=18)
            {
                if (typeOfDay=="weekday")
                {
                    Console.WriteLine($"12$");
                }
                else if (typeOfDay == "weekend")
                {
                    Console.WriteLine($"15$");
                }
                else if(typeOfDay=="holiday")
                {
                    Console.WriteLine($"5$");
                }
            }
            else if (18 < age && age <= 64)
            {
                if (typeOfDay == "weekday")
                {
                    Console.WriteLine($"18$");
                }
                else if (typeOfDay == "weekend")
                {
                    Console.WriteLine($"20$");
                }
                else if (typeOfDay == "holiday")
                {
                    Console.WriteLine($"12$");
                }
            }
            else if (64 < age && age <= 122)
            {
                if (typeOfDay == "weekday")
                {
                    Console.WriteLine($"12$");
                }
                else if (typeOfDay == "weekend")
                {
                    Console.WriteLine($"15$");
                }
                else if (typeOfDay == "holiday")
                {
                    Console.WriteLine($"10$");
                }
            }
        }
    }
}
