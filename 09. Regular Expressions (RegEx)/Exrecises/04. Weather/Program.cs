using System;
using System.Linq;

namespace _04._Weather
{
    class Weather
    {
        public string City { get; set; }
        public double Temperature { get; set; }
        public string TypeOfWeather { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                .Split()
                .ToArray();
            string regex = @"([A-Z]{2})(\d+(\.\d+))()[A-Za-z]+\|";

            while (input[0]!="end")
            {

                input = Console.ReadLine()
                .Split()
                .ToArray();
            }
        }
        static Weather ReadInput(string input)
        {

        }
    }
}
