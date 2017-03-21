using System;

public class Program
{
	public static void Main()
	{

		var juniorBike = int.Parse(Console.ReadLine());
		var seniorBike	 = int.Parse(Console.ReadLine());
		var kindTrace = Console.ReadLine().ToLower();

		var juniorTax = 0.00;
		var seniorTax = 0.00;
		var totalSum = 0.00;
		switch(kindTrace)
		{
		case "trail":
			juniorTax=5.50;
			seniorTax=7.00;
			break;


		case "cross-country":
			juniorTax=8.00;
			seniorTax=9.50;
			if((juniorBike+seniorBike)>=50)
			{
			juniorTax=juniorTax*0.75;//juniorTax-juniorTax*0.25
			seniorTax=seniorTax*0.75;
			}
			break;


		case "downhill":
			juniorTax=12.25;
			seniorTax=13.75;
			break;


		case "road":
			juniorTax=20.00;
			seniorTax=21.50;
			break;

		default:
			break;
		}
		totalSum=juniorTax*juniorBike+seniorTax*seniorBike;
		totalSum=totalSum*0.95;//totalSum=totalSum-totalSum*0.05
		Console.WriteLine("{0:F2}",totalSum);
	}
}
