using System;

public class Program
{
	public static void Main()
	{
		int n = int.Parse(Console.ReadLine());
		int leftSum = 0;
		int rightSum= 0;
		for (int i = 0; i<n; i++)
			{
			 leftSum += int.Parse(Console.ReadLine());


			}
				for (int i = 0; i<n; i++)
			{
			 rightSum += int.Parse(Console.ReadLine());


			}

		if(Math.Abs(leftSum-rightSum)==0)
		{
			Console.WriteLine("Yes sum,{0}",Math.Abs(leftSum));

		}
		else Console.WriteLine("No diff,{0}",Math.Abs(leftSum-rightSum));


	}
}
