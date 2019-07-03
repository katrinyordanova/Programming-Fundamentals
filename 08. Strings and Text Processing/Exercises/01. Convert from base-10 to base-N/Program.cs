using System;
using System.Linq;
using System.Collections;
using System.Numerics;

namespace _01._Convert_from_base_10_to_base_N
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ').ToArray();           
            int baseN = int.Parse(input[0]);
            BigInteger baseTen = BigInteger.Parse(input[1]);
            BigInteger remainder = 0;
            string result = "";

            while (baseTen>0)
            {
                remainder = baseTen % baseN;
                baseTen /= baseN;
                result = remainder.ToString() + result;
            }
			
            Console.WriteLine(result);
        }
    }
}
