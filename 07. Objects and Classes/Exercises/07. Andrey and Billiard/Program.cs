using System;
using System.Linq;
using System.Collections.Generic;

namespace _07._Andrey_and_Billiard
{
    class Customer
    {
        public string Name { get; set; }
        public Dictionary<string,int> ShopList { get; set; }
        public string Bill { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfOrders = int.Parse(Console.ReadLine());
            Dictionary<string, int> menu = new Dictionary<string, int>();
            
            for (int i = 0; i < numberOfOrders; i++)
            {
                string[] input = Console.ReadLine().Split('-');
                string drink = input[0];
                int price = int.Parse(input[1]);

                if (!menu.ContainsKey(drink))
                {
                    menu.Add(drink, price);
                }
                else
                {
                    menu[drink] = price;
                }
            }

            List<Customer> allCustomers = new List<Customer>();
            
            while (true)
            {
                string[] information = Console.ReadLine().Split('-', ',');

                if (information[0]=="end")
                {
                    break;
                }

                string nameOfClient = information[0];
                string product = information[1];
                int quantity = int.Parse(information[2]);

                if (!menu.ContainsKey(product))
                {
                    continue;
                }
            }

           
        }
    }
}
