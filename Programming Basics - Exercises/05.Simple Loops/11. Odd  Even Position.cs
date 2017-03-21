using System;

public class Program
{
	public static void Main()
	{
		double n = double.Parse(Console.ReadLine());
		double oddSum = 0;
        double oddMin = 1000000000.0;
        double oddMax = -1000000000.0;
        double evenSum = 0;
        double evenMin = 1000000000.0;
        double evenMax = -1000000000.0;

		for(int i = 1; i<=n; i++)
		{
		double num = double.Parse(Console.ReadLine());
			if (i % 2 == 0)
			{
			evenSum += num;
			evenMin = Math.Min(evenMin, num);
            evenMax = Math.Max(evenMax, num);
			}
			else
			{
			oddSum += num;
			oddMin = Math.Min(oddMin, num);
			oddMax = Math.Max(oddMax, num);
			}
		}

		 Console.WriteLine("OddSum="+oddSum);
        if (oddMin == 1000000000.0)
        {
            Console.WriteLine("OddMin=No");
        }
        else
        {
            Console.WriteLine("OddMin="+oddMin);
        }
        if (oddMax == -1000000000.0)
        {
            Console.WriteLine("OddMax=No");
        }
        else
        {
            Console.WriteLine("OddMax="+oddMax);
        }

        Console.WriteLine("EvenSum="+evenSum);

		if (evenMin == 1000000000.0)
        {
            Console.WriteLine("evenMin=No");
        }
        else
        {
            Console.WriteLine("evenMin="+ evenMin);
        }
        if (evenMax == -1000000000.0)
        {
            Console.WriteLine("evenMax=No");
        }
        else
        {
            Console.WriteLine("evenMax="+ evenMax);
        }

	}


}
