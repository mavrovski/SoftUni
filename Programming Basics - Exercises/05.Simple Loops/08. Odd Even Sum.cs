using System;

public class Program
{
	public static void Main()
	{
		var num = int.Parse(Console.ReadLine()); //vhod za broi 4isla
		double evenSum = 0;  // nulevi promenlivi za 4etno i ne4etno 4islo
		double oddSum = 0;
		for (int i = 0; i < num; i++) //cikala for za kalkulaciq na broi 4isla
		{
			if(i % 2==0)
			{
			evenSum += double.Parse(Console.ReadLine());// ako 4isloto e 4etno evenSum stava 4etno 4islo
			}
			else
			{
			oddSum += double.Parse(Console.ReadLine());//ako e ne4etno
			}


		}
		if(Math.Abs(evenSum-oddSum)==0) // proverka dali razlikata mejdu num broq 4isla dali e ravna na 0
		{
			Console.WriteLine("Yes sum = {0}",evenSum);//ako e taka

		}
		else Console.WriteLine("No diff = {0}",Math.Abs(evenSum-oddSum));//ako ne e taka

	}
}
