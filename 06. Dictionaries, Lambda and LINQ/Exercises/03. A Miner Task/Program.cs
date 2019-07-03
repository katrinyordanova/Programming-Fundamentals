using System;
using System.Linq;
using System.Collections.Generic;

namespace _03._A_Miner_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            Dictionary<string, int> resources = new Dictionary<string, int>();
            string metal = " ";
            int quantity =0;

            while (command!="stop")
            {
                metal = command;
                quantity = int.Parse(Console.ReadLine());

                if (resources.ContainsKey(metal))
                {
                    resources[metal] += quantity;
                }
                else
                {
                    resources.Add(metal, quantity);
                }
                command = Console.ReadLine();
            }

            foreach (var resource in resources)
            {
                Console.WriteLine($"{resource.Key} -> {resource.Value}");
            }
        }
    }
}
