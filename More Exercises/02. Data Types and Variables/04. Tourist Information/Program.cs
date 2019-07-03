using System;

namespace _04._Tourist_Information
{
    class Program
    {
        static void Main(string[] args)
        {
            string unit = Console.ReadLine().ToLower();
            double value = double.Parse(Console.ReadLine());
            double convertedUnit = 0;

            if (unit=="miles")
            {
                convertedUnit += value * 1.6;
                Console.WriteLine($"{value} {unit} = {convertedUnit:F2} kilometers");
            }
            else if (unit=="inches")
            {
                convertedUnit += 2.54 * value;
                Console.WriteLine($"{value} {unit} = {convertedUnit:F2} centimeters");
            }
            else if (unit == "feet")
            {
                convertedUnit += 30 * value;
                Console.WriteLine($"{value} {unit} = {convertedUnit:F2} centimeters");
            }
            else if (unit == "yards")
            {
                convertedUnit += 0.91 * value;
                Console.WriteLine($"{value} {unit} = {convertedUnit:F2} meters");
            }
            else if (unit == "gallons")
            {
                convertedUnit += 3.8 * value;
                Console.WriteLine($"{value} {unit} = {convertedUnit:F2} liters");
            }
        }
    }
}
