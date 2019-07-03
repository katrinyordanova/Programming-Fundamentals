using System;

namespace _06._Catch_the_Thief
{
    class Program
    {
        static void Main(string[] args)
        {
            string dataType = Console.ReadLine();
            int numberOfIDs = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfIDs; i++)
            {
                string ids = Console.ReadLine();

                if (dataType == "sbyte")
                {
                    try
                    {
                        sbyte parcedNumber = sbyte.Parse(ids);
                    }
                    catch (Exception)
                    {

                        throw;
                    }
                }

            }
        }
    }
}
