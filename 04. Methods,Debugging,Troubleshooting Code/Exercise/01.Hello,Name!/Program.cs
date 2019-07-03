using System;

namespace _01.Hello_Name_
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            PrintName(name);
        }
		
        static void PrintName(string name)
        {
            Console.WriteLine($"Hello, {name}!");
        }
    }
}
