using System;

namespace _05._Temperature_Conversion
{
    class Program
    {
        static void Main(string[] args)
        {
            double input = double.Parse(Console.ReadLine());
            double result = ConvertToCelsius(input);
            Console.WriteLine($"{result:f2}");
        }
		
        static double ConvertToCelsius(double input)
        {
            return (input-32)*5 / 9;
        }

        //or
        //static void Main(string[] args)
        //{
        //    double input = double.Parse(Console.ReadLine());
        //    ConvertToCelsius(input);
        //}
        //static void ConvertToCelsius(double input)
        //{
        //    double convert = (input - 32) * 5 / 9;
        //    Console.WriteLine($"{convert:f2}");
        //}
    }
}
