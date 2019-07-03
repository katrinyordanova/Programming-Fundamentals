using System;

namespace _04._Draw_a_Filled_Square
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            DrawFilledSquare(input);
        }
		
        static void DrawFilledSquare(int input)
        {
            Console.WriteLine(new string('-',input * 2));

            for (int i = 1; i <= input-2; i++)
            {
                Console.Write('-');

                for (int j = 1; j <= input-1; j++)
                {
                    Console.Write("\\/");
                }  

                Console.WriteLine('-');
            }
			
            Console.WriteLine(new string('-', input * 2));
        }
    }
}
