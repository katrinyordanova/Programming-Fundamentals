using System;

namespace _02._Rectangle_Area
{
    class Program
    {
        static void Main(string[] args)
        {
            float width = float.Parse(Console.ReadLine());
            float height = float.Parse(Console.ReadLine());
            float area = width * height;
			
            Console.WriteLine($"{area:f2}");
        }
    }
}
