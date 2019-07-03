﻿using System;
using System.Linq;
using System.Collections.Generic;

namespace _07._Count_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            input.Sort();
            int prevousNumber = input[0];
            input.Add(int.MaxValue);

            int count = 1;

            for (int i = 1; i < input.Count; i++)
            {
                int currentNumber = input[i];
				
                if (prevousNumber == currentNumber)
                {
                    count++;
                }
                else
                {
                    Console.WriteLine("{0} -> {1}", prevousNumber, count);
                    count = 1;
                }
				
                prevousNumber = currentNumber;
            }
        }
    }
}
