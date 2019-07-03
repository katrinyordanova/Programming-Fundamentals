using System;
using System.Linq;
using System.Collections.Generic;

namespace _01._Phonebook
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] command = Console.ReadLine()
                .Split(' ')
                .ToArray();
            Dictionary<string, string> phonebook = new Dictionary<string, string>();
            SortedDictionary<string, string> printAll = new SortedDictionary<string, string>();

            while (command[0] != "END")
            {
                if (command[0] == "A")
                {
                    string key = command[1];
                    string value = command[2];

                    if (phonebook.ContainsKey(key))
                    {
                        phonebook[key] = value;
                    }
                    else
                    {
                        phonebook.Add(key, value);
                    }
                }
                else if (command[0] == "S")
                {
                    string searchInfo = command[1];
                    if (phonebook.ContainsKey(searchInfo))
                    {
                        Console.WriteLine($"{searchInfo} -> {phonebook[searchInfo]}");
                    }
                    else
                    {
                        Console.WriteLine($"Contact {searchInfo} does not exist.");
                    }
                }
                if (command[0]=="ListAll")
                {
					foreach (var item in phonebook.OrderBy(x=>x.Key))
                    {
                        Console.WriteLine($"{item.Key} -> {item.Value}");
                    }
                 }
                command = Console.ReadLine()
                .Split(' ')
                .ToArray();
            }
        }
    }
}
