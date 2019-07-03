using System;
using System.Collections.Generic;

namespace _07._Sales_Report
{
    class Program
    {
        static void Main(string[] args)
        {
            int counterOfCities = int.Parse(Console.ReadLine());
            Sale[] sales = new Sale[counterOfCities];

            for (int i = 0; i < counterOfCities; i++)
            {
                sales[i] = ReadSale(Console.ReadLine());
            }

            SortedDictionary<string, decimal> information = new SortedDictionary<string, decimal>();

            foreach (var sale in sales)
            {
                if (!information.ContainsKey(sale.Town))
                {
                    information[sale.Town] = sale.Quantity * sale.Price;
                }
                else
                {
                    information[sale.Town] += sale.Quantity * sale.Price;
                }
            }

            foreach (var info in information)
            {
                Console.WriteLine($"{info.Key} -> {info.Value:F2}");
            }
        }
		
        static Sale ReadSale(string input)
        {
            string[] token = input.Split(' ');

            return new Sale
            {
                Town = token[0],
                Product = token[1],
                Price = decimal.Parse(token[2]),
                Quantity = decimal.Parse(token[3])
            };
        }

    }
    class Sale
    {
        public string Town { get; set; }
        public string Product { get; set; }
        public decimal Price { get; set; }
        public decimal Quantity { get; set; }
    }
}
