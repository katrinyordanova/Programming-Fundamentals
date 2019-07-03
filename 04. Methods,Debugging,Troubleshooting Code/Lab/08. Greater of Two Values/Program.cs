using System;
using System.Linq;

namespace _08._Greater_of_Two_Values
{
    class Program
    {
        static void Main(string[] args)
        {
            string typeOfVariables = Console.ReadLine();

            if (typeOfVariables=="string")
            {
                string firstString = Console.ReadLine();
                string secondString = Console.ReadLine();
                string theLongestString = StringGetMax(firstString, secondString);
                Console.WriteLine(theLongestString);

            }
            else if (typeOfVariables=="int")
            {
                int firstInt = int.Parse(Console.ReadLine());
                int secondInt = int.Parse(Console.ReadLine());
                int maxInt = IntGetMax(firstInt, secondInt);
                Console.WriteLine(maxInt);
            }
            else if(typeOfVariables=="char")
            {
                char firstChar = char.Parse(Console.ReadLine());
                char secondChar = char.Parse(Console.ReadLine());
                char maxChar = CharGetMax(firstChar, secondChar);
                Console.WriteLine(maxChar);
            }
        }
		
        static string StringGetMax(string firstString, string secondString)
        {
            if(firstString.CompareTo(secondString) >=0)
            {
                return firstString;
            }
            else
            {
                return secondString;
            }   
        }
		
        static int IntGetMax(int firstInt, int secondInt)
        {
            if (firstInt>=secondInt)
            {
                return firstInt;
            }
            else
            {
                return secondInt;
            }
        }
		
        static char CharGetMax(char firstChar, char secondChar)
        {
            if (firstChar >= secondChar)
            {
                return firstChar;
            }
            else
            {
                return secondChar;
            }
        }
    }
}
