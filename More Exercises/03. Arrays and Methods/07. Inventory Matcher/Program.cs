using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Inventory_Matcher
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string>items = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToList();
            List<long> quantity= Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(long.Parse)
                .ToList();
           List<decimal> prices = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(decimal.Parse)
                .ToList();
            string command = Console.ReadLine();

            while (command!="done")
            {
                int checkIfThere1=items.IndexOf(command);
                int checkIfThere2 = items.IndexOf(command);
                int checkIfThere3 = items.IndexOf(command);
                Console.WriteLine($"{items[checkIfThere1]} costs: {prices[checkIfThere2]}; Available quantity: {quantity[checkIfThere3]}");
                command = Console.ReadLine();
            }
        }
    }
}
