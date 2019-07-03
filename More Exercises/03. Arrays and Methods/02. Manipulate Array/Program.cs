using System;
using System.Linq;
using System.Collections;

namespace _02._Manipulate_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] array = Console.ReadLine().
                Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            int numberOfLinesWithCommands = int.Parse(Console.ReadLine());

            for (int j = 0; j < numberOfLinesWithCommands; j++)
            {
                string[] command = Console.ReadLine().Split(' ');

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
                    array[int.Parse(command[1])] = command[2];
                }
                
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
