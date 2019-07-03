using System;

namespace _05._Boolean_Variable
{
    class Program
    {
        static void Main(string[] args)
        {
            bool command = Convert.ToBoolean(Console.ReadLine());

            if (command)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
