using System;
using System.Linq;
using System.Collections.Generic;

namespace _02._Change_List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
            string[] command=Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            while (command[0] != "Odd" && command[0] != "Even")
            {
                    if (command[0] == "Delete")
                    {
                        int index = int.Parse(command[1]);
                        numbers.RemoveAll(x => x == index);
                    }
                    else if (command[0] == "Insert")
                    {
                        int index = int.Parse(command[1]);
                        int value = int.Parse(command[2]);
                        numbers.Insert(value, index);
                    }

                command = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            }
			
            if (command[0]=="Even")
            {
                numbers.RemoveAll(x => x % 2 != 0);
                 
            }
            else if (command[0] == "Odd")
            {
                numbers.RemoveAll(x => x % 2 == 0);
            }
			
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
