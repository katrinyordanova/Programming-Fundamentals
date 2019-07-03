using System;

namespace _02.Circle_Area
{
    class Program
    {
        static void Main(string[] args)
        {
            double radius = double.Parse(Console.ReadLine());
            double calculate = radius * radius * Math.PI;

            Console.WriteLine($"{calculate:F12}");
        }
    }
}
