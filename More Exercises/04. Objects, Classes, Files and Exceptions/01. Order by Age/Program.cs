using System;
using System.Linq;
using System.Collections.Generic;

namespace _01._Order_by_Age
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> tokens = Console.ReadLine().Split().ToList();
            List<dynamic> finalInformation = new List<dynamic>();

            while (tokens[0]!="End")
            {
                string name = tokens[0];
                string idNumber = tokens[1];
                int age = int.Parse(tokens[2]);

                dynamic person = new { name, idNumber, age };
                finalInformation.Add(person);

                tokens = Console.ReadLine().Split().ToList();
            }

            foreach (var information in finalInformation.OrderBy(x=>x.age))
            {
                Console.WriteLine($"{information.name} with ID: {information.idNumber} is {information.age} years old.");
            }
        }
    }
}
