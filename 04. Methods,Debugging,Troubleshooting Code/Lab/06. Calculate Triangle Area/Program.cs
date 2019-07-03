using System;

namespace _06._Calculate_Triangle_Area
{
    class Program
    {
        static void Main(string[] args)
        {
            double length = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            double result = TriangleArea(length, height);
            Console.WriteLine(result);
        }
		
        static double TriangleArea(double length, double height)
        {
            return (length * height) / 2;
        }
    }
}
