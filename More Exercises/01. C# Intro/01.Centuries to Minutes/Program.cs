using System;

namespace Intro_More_Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());

            int centuries =input;
            int years = centuries * 100;
            int days = (int)(years * 365.2422);
            int hours = days * 24;
            int minutes = hours * 60;

            Console.WriteLine($"{input} centuries = {years} years = {days} days = {hours} hours = {minutes} minutes");
        }
    }
}
