using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Exact_Sum_of_Real_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            decimal counter = 0;

            for (int i = 0; i < number; i++)
            {
                counter += decimal.Parse(Console.ReadLine());
            }
			
            Console.WriteLine(counter);
        }
    }
}
