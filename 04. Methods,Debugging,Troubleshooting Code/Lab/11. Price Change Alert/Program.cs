using System;

class PriceChangeAlert
{
    static void Main()
    {
        int numberOfPrices = int.Parse(Console.ReadLine());
        double threshold = double.Parse(Console.ReadLine());
        double firstPrice = double.Parse(Console.ReadLine());

        for (int i = 0; i < numberOfPrices - 1; i++)
        {
            double newPrize = double.Parse(Console.ReadLine());
            double div = Procent(firstPrice, newPrize);
            bool isSignificantDifference = IsThereADifference(div, threshold);
            string message = Get(newPrize, firstPrice, div, isSignificantDifference);
            Console.WriteLine(message);

            firstPrice = newPrize;
        }
    }

    private static string Get(double newPrize, double firstPrice, double difference, bool etherTrueOrFalse)
    {
        string changeTo = "";

        if (difference == 0)
        {
            changeTo = string.Format("NO CHANGE: {0}", newPrize);
        }
        else if (!etherTrueOrFalse)
        {
            changeTo = string.Format("MINOR CHANGE: {0} to {1} ({2:F2}%)", firstPrice, newPrize, difference*100);
        }
        else if (etherTrueOrFalse && (difference > 0))
        {
            changeTo = string.Format("PRICE UP: {0} to {1} ({2:F2}%)", firstPrice, newPrize, difference/100);
        }
        else if (etherTrueOrFalse && (difference < 0))
            changeTo = string.Format("PRICE DOWN: {0} to {1} ({2:F2}%)", firstPrice, newPrize, difference);
        return changeTo;
    }
	
    private static bool IsThereADifference(double threshold, double isDifferent)
    {
        if (Math.Abs(threshold) >= isDifferent)
        {
            return true;
        }
        return false;
    }

    private static double Procent(double l, double newPrize)
    {
        double result = (newPrize - l) / l;
        return result;
    }
}
