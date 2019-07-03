using System;

namespace _03._Water_Overflow
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfLiters = int.Parse(Console.ReadLine());
            int counter = 0;
            int capacity = 255;

            for (int i = 0; i < numberOfLiters; i++)
            {
                int liters = int.Parse(Console.ReadLine());
                
                if (counter+liters<=capacity)
                {
                    counter += liters;

                }
                else
                {
                    Console.WriteLine("Insufficient capacity!");
                }
            }
			
            Console.WriteLine(counter);
        }
    }
}
