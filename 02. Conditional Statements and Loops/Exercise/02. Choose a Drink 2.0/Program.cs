using System;

namespace Conditional_Statements_and_Loops_Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            string profession = Console.ReadLine();
            double quantity = double.Parse(Console.ReadLine());

            if (profession=="Athlete")
            {
                Console.WriteLine($"The Athlete has to pay {quantity * 0.7:f2}.");
            }
            else if (profession=="Businessman")
            {
                Console.WriteLine($"The Businessman has to pay {quantity * 1.0:f2}.");
            }
            else if (profession == "Businesswoman")
            {
                Console.WriteLine($"The Businesswoman has to pay {quantity * 1.0:f2}.");
            }
            else if (profession == "SoftUni Student")
            {
                Console.WriteLine($"The SoftUni Student has to pay {quantity * 1.7:f2}.");
            }
            else if (profession == "SoftUni Student")
            {
                Console.WriteLine($"The SoftUni Student has to pay {quantity * 1.7:f2}.");
            }
            else 
            {
                Console.WriteLine($"The {profession} has to pay {quantity * 1.2:f2}.");
            }
        }
    }
}
