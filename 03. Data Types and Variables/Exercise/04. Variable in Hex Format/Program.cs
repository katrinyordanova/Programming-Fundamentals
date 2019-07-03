using System;

namespace _04._Variable_in_Hex_Format
{
    class Program
    {
        static void Main(string[] args)
        {
            //string input = Console.ReadLine();

            //int convertMe = Convert.ToInt32(input, 16);

            //Console.WriteLine(convertMe);

            int convertInput = Convert.ToInt32(Console.ReadLine(),16);

            Console.WriteLine(convertInput);
        }
    }
}
