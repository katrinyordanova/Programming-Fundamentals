using System;

namespace _05._Weather_Forecast
{
    class Program
    {
        static void Main(string[] args)
        {
            string input =Console.ReadLine();

            try
            {
                sbyte number = sbyte.Parse(input);
                Console.WriteLine("Sunny");
            }
            catch (Exception)
            {
                try
                {
                    int number = int.Parse(input);
                    Console.WriteLine("Cloudy");
                }
                catch (Exception)
                {
                    try
                    {
                        long number = long.Parse(input);
                        Console.WriteLine("Windy");
                    }
                    catch (Exception)
                    {
                        try
                        {
                            float number = float.Parse(input);
                            Console.WriteLine("Rainy");
                        }
                        catch (Exception)
                        {
                        }
                    }
                }
            } 
        }
    }
}
