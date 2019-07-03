using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Odd_Occurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine().ToLower();
            string[] elements = input.Split(' ');
            Dictionary<string, int> newElements = new Dictionary<string, int>();

            foreach (var element in elements)
            {
                if (newElements.ContainsKey(element))
                {
                    newElements[element]++;
                }
                else
                {
                    newElements[element] = 1;
                }
            }

            List<string> result = new List<string>();

            foreach (var element in newElements.Keys)
            {
                if (newElements[element]%2==1)
                {
                    result.Add(element);
                }
                
            }
			
            Console.Write(string.Join(", ", result));
        }
    }
}
