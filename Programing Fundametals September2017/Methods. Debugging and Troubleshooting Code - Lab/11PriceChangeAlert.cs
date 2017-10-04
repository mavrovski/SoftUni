using System;

class PriceChangeAlert
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());

        double border = double.Parse(Console.ReadLine());

        double lastPrice = double.Parse(Console.ReadLine());

        for (int i = 0; i < number - 1; i++)
        {
            double newPrice = double.Parse(Console.ReadLine());
            double div = PrecentCalculation(lastPrice, newPrice);
            bool isSignificantDifference = isDifference(div, border);
            string message = Get(newPrice, lastPrice, div, isSignificantDifference);
            Console.WriteLine(message);

            lastPrice = newPrice;
        }
    }

    private static string Get(double newPrice, double lastPrice, double difference, bool etherTrueOrFalse)

    {
        string to = "";
        if (difference == 0)
        {
            to = string.Format("NO CHANGE: {0}", newPrice);
        }
        else if (!etherTrueOrFalse)
        {
            to = string.Format("MINOR CHANGE: {0} to {1} ({2:F2}%)", lastPrice, newPrice, difference*100);
        }
        else if (etherTrueOrFalse && (difference > 0))
        {
            to = string.Format("PRICE UP: {0} to {1} ({2:F2}%)", lastPrice, newPrice, difference*100);
        }
        else if (etherTrueOrFalse && (difference < 0))
            to = string.Format("PRICE DOWN: {0} to {1} ({2:F2}%)", lastPrice, newPrice, difference*100);
        return to;
    }
    private static bool isDifference(double border, double isDiff)
    {
        if (Math.Abs(border) >= isDiff)
        {
            return true;
        }
        return false;
    }

    private static double PrecentCalculation(double oldPrice, double newPrice)
    {
        double precent = (newPrice - oldPrice) / oldPrice;
        return precent;
    }
}
