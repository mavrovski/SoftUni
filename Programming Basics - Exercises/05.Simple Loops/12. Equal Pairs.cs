using System;

public class Program
{
	public static void Main()
	{
		double n = double.Parse(Console.ReadLine());
		double pairSum = 0;
		double valueOne =0;
		double valueTwo =0;
		double oldPairSum = 0;
		double diff = 0;
		double maxDiff = 0;
		for(int i = 0; i<n;i++)
		{
		valueOne = double.Parse(Console.ReadLine());
		valueTwo = double.Parse(Console.ReadLine());

		if (i == 0)
		{
		oldPairSum=valueOne+valueTwo;


		}
		else
		{
		pairSum=valueOne+valueTwo;
		diff = Math.Abs(pairSum-oldPairSum);
			 if (diff > maxDiff)
                    {
                        maxDiff =diff;
                    }
               oldPairSum=pairSum;
		}


		}

		 if (maxDiff  == 0)
        {
            Console.WriteLine("Yes, value ={0}", oldPairSum);
        }
        else
        {
            Console.WriteLine("No, maxdiff ={0}", maxDiff);
        }
	}

}
