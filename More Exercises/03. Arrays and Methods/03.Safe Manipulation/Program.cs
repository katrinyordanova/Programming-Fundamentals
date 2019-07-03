using System;
using System.Linq;

namespace _03.Safe_Manipulation
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] array = Console.ReadLine().
                Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            string[] command = Console.ReadLine().Split(' ');

            while (command[0]!="END")
            {
                if (command[0] == "Reverse")
                {
                    Array.Reverse(array);
                }
                else if (command[0] == "Distinct")
                {
                    array = RemoveDuplicates(array);
                }
                else if (command[0] == "Replace")
                {
                    int index = int.Parse(command[1]);
                    if (0<=index && index<array.Count())
                    {
                        array[int.Parse(command[1])] = command[2];
                    }
                    else
                    {
                        Console.WriteLine("Invalid input!");
                    }
                }
                else 
                {
                    Console.WriteLine("Invalid input!");
                }
                command = Console.ReadLine().Split(' ');

            }
            Console.WriteLine(string.Join(", ", array));
        }

        private static string[] RemoveDuplicates(string[] array)
        {
            int distinct = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (string.IsNullOrEmpty(array[i]))
                    continue;
                else
                    distinct++;

                for (int j = 0; j < array.Length; j++)
                {
                    if (i == j)
                        continue;
                    if (array[i].Equals(array[j]))
                        array[j] = string.Empty;
                }
            }

            if (array.Length == distinct)
                return array;

            string[] distinctElements = new string[distinct];

            for (int i = 0, j = 0; i < array.Length; i++)
                if (!string.IsNullOrEmpty(array[i]))
                    distinctElements[j++] = array[i];

            System.Diagnostics.Debug.Assert(distinctElements.Length == distinct);

            return distinctElements;
        }
    }
}
