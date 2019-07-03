using System;

namespace _04._Month_Printer
{
    class Program
    {
        static void Main(string[] args)
        {
            int monthOfTheYear = int.Parse(Console.ReadLine());

            switch (monthOfTheYear)
            {
                case 1: Console.WriteLine("January");
                    break;
                case 2:
                    Console.WriteLine("Febuary");
                    break;
                case 3:
                    Console.WriteLine("April");
                    break;
                case 4:
                    Console.WriteLine("May");
                    break;
                case 5:
                    Console.WriteLine("Jun");
                    break;
                case 6:
                    Console.WriteLine("July");
                    break;
                case 7:
                    Console.WriteLine("August");
                    break;
                case 8:
                    Console.WriteLine("September");
                    break;
                case 9:
                    Console.WriteLine("October");
                    break;
                case 10:
                    Console.WriteLine("November");
                    break;
                case 11:
                    Console.WriteLine("December");
                    break;
                case 12:
                    Console.WriteLine("January");
                    break;
                default: Console.WriteLine("Error!");
                    break;
            }
        }
    }
}
