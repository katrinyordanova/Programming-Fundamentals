using System;
using System.Text.RegularExpressions;
using System.Linq;

namespace _02._Email_me
{
    class Program
    {
        static void Main(string[] args)
        {
            string email = Console.ReadLine();
            int username = email.Split('@')
                .First()
                .ToCharArray()
                .Select(x=>(int)x)
                .Sum();
            int domain = email.Split('@')
                .Last()
                .ToCharArray()
                .Select(x => (int)x)
                .Sum();

            if (username-domain<0)
            {
                Console.WriteLine("She is not the one.");
            }
            else
            {
                Console.WriteLine("Call her!");
            }
        }
    }
}
