using System;
using System.Linq;

namespace _01._Day_of_Week
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            string[] daysOfTheWeek = {"Monday",
                "Tuesday",
                "Wednesday",
                "Thursday",
                "Friday",
                "Saturday",
                "Sunday" };

            if (input >= 1 && input <= 7)
            {
                Console.WriteLine(daysOfTheWeek[input - 1]);
            }
            else
            {
                Console.WriteLine("Invalid Day!");
            }
        }
    }
}