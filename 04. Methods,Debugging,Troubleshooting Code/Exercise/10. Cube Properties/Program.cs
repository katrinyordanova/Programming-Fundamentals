using System;

namespace _10._Cube_Properties
{
    class Program
    {
        static void Main(string[] args)
        {
            double side = double.Parse(Console.ReadLine());
            string findMe = Console.ReadLine();

            switch (findMe)
            {
                case "face": Console.WriteLine($"{0:F2}",FindFaceDiagonals(side));
                    break;
                case "volume":
                    Console.WriteLine($"{0:F2}", FindVolume(side));
                    break;
                case "space":
                    Console.WriteLine($"{0:F2}", FindSpaceDiagonals(side));
                    break;
                case "area":
                    Console.WriteLine($"{0:F2}", FindSurfaceArea(side));
                    break;
            }
        }
		
        static double FindFaceDiagonals(double side)
        {
            double result1 = Math.Sqrt(2 * (side * side));
            return result1;
        }
		
        static double FindVolume(double side)
        {
            double result2 = Math.Pow(side,3);
            return result2;
        }
		
        static double FindSpaceDiagonals(double side)
        {
            double result3 = Math.Sqrt(3 * (side * side));
            return result3;
        }
		
        static double FindSurfaceArea(double side)
        {
            double result4 = 6 * (side * side);
            return result4;
        }
    }
}
