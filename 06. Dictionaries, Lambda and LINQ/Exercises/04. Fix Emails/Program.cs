using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Fix_Emails
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();

            Dictionary<string, string> information = new Dictionary<string, string>();
            string name = "";
            string email = "";

            while (command!="stop")
            {
                name = command;
                email = Console.ReadLine();
                if (!information.ContainsKey(command))
                {
                    information.Add(name, email);
                }
                command = Console.ReadLine();
            }
            foreach (var info in information.Where(x => !x.Value.EndsWith(".us") && !x.Value.EndsWith(".uk")))
            {
                Console.WriteLine($"{info.Key} -> {info.Value}");
            }
        }
    }
}
