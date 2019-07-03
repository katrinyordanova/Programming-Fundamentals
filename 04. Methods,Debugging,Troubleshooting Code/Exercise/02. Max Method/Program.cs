using System;

namespace _02._Max_Method
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int thirdNumber = int.Parse(Console.ReadLine());
            int theBiggestOfThemAll = GetMax(firstNumber, secondNumber, thirdNumber);
			
            Console.WriteLine(theBiggestOfThemAll);
        }
		
        static int GetMax(int firstNumber, int secondNumber,int thirdNumber)
        {
            int theBiggestOfBoth = Math.Max(firstNumber, secondNumber);
            int theBiggestOfThemAll = Math.Max(theBiggestOfBoth, thirdNumber);
            return theBiggestOfThemAll;

            //or
            //int theBiggestOfThemAll = Math.Max(Math.Max(firstNumber,secondNumber), thirdNumber);

        }

    }
}
