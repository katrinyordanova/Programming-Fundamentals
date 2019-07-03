using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Elevator
{
    class Elevator
    {
        static void Main(string[] args)
        {       
            int numberOfPeople = int.Parse(Console.ReadLine());
            int capacity = int.Parse(Console.ReadLine());

            var course =Math.Ceiling (1.0*numberOfPeople / capacity);

            Console.WriteLine(course);
        }
    }
}
