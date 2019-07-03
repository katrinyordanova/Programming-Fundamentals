using System;
using System.Linq;

namespace _01._Largest_Common_End
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] fisrtArray = Console.ReadLine().Split(' ').ToArray();
            string[] secondArray = Console.ReadLine().Split(' ').ToArray();

            int leftSideCounter = 0;
            int rightSideCounter = 0;

            for (int i = 0; i < Math.Min(fisrtArray.Length,secondArray.Length); i++)
            {
                if (fisrtArray[i]==secondArray[i])
                {
                    leftSideCounter++;
                }
                else if (fisrtArray[fisrtArray.Length-1-i]== secondArray[secondArray.Length-1-i])
                {
                    rightSideCounter++;
                }
            }
            if (leftSideCounter>=rightSideCounter)
            {
                Console.WriteLine(leftSideCounter);
            }
            else
            {
                Console.WriteLine(rightSideCounter);
            }
        }
    }
}
