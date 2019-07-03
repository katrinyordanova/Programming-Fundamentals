using System;

namespace _03._Miles_to_Kilometerss
{
    class Program
    {
        static void Main(string[] args)
        {
            double miles = double.Parse(Console.ReadLine());
            double convertToKilometers = miles * 1.60934;

            Console.WriteLine($"{convertToKilometers:F2}");
        }
    }
}
