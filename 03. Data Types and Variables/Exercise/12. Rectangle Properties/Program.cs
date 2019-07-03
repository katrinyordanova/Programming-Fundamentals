using System;

namespace _12._Rectangle_Properties
{
    class Program
    {
        static void Main(string[] args)
        {
            double length = double.Parse(Console.ReadLine());
            double width = double.Parse(Console.ReadLine());

            double perimeter = 2 * length + 2 * width;
            double area = length * width;
            double diagonal = Math.Sqrt(Math.Pow(length,2) + (Math.Pow(width, 2)));

            Console.WriteLine(perimeter);
            Console.WriteLine(area);
            Console.WriteLine(diagonal);
        }
    }
}
