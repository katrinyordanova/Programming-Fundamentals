﻿using System;

namespace _02.Add_Two_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
			
            int sum = firstNumber + secondNumber;

            Console.WriteLine($"{firstNumber} + {secondNumber} = {sum}");
        }
    }
}
