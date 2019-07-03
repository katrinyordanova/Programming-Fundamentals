using System;

namespace Conditional_Statements_and_Loops___Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            double grade = double.Parse(Console.ReadLine());

            if (grade>=3.00)
            {
                Console.WriteLine("Passed!");
            }
           
        }
    }
}
