using System;
using System.Linq;
using System.Collections.Generic;

namespace _05._Array_Manipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            List<long> numbers = Console.ReadLine()
                .Split( ' ')
                .Select(long.Parse)
                .ToList();
            string action = Console.ReadLine();
                
            while (action!="print")
            {
                string[] command = action.Split(' ');

                switch (command[0])
                {
                    case "add":
                        int index = int.Parse(command[1]);
                        long element = long.Parse(command[2]);
                        numbers.Insert(index, element);
                        break;
                    case "addMany":
                        int index2 = int.Parse(command[1]);
                        List<long> elementsToAdd = command.Skip(2).Select(long.Parse).ToList();
                        numbers.InsertRange(index2, elementsToAdd);
                        break;
                    case "contains":
                        long element2 = long.Parse(command[1]);
                        Console.WriteLine(numbers.IndexOf(element2));
                        break;
                    case "remove":
                        int index3 = int.Parse(command[1]);
                        numbers.RemoveAt(index3);
                        break;
                    case "shift":
                        int positions = int.Parse(command[1]);

                        for (int i = 0; i < positions; i++)
                        {
                            long lastElement = numbers[0];

                            for (int j = 0; j < numbers.Count - 1; j++)
                            {
                                numbers[j] = numbers[j + 1];
                            }
                            numbers[numbers.Count - 1] = lastElement;
                        }
                        break;
                    case "sumPairs":
                        List<long> sumManyPairs = new List<long>();

                        for (int i = 0; i < numbers.Count - 1; i+=2)
                        {
                            sumManyPairs.Add(numbers[i] + numbers[i + 1]);
                        }
                        if (numbers.Count % 2 == 1)
                        {
                            sumManyPairs.Add(numbers[numbers.Count - 1]);
                        }
                        numbers = sumManyPairs;
                        break;
                }
                action=Console.ReadLine();
            }
			
            Console.WriteLine($"[{string.Join(", ", numbers)}]");
        }
    }
}
