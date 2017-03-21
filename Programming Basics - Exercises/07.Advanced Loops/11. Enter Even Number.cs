using System;

public class Program
{
	public static void Main()

	{

		int n;


		while(true)
		{
			try
			{
			Console.Write("Enter Even Number");
			 n = int.Parse(Console.ReadLine());
				if(n %2 ==0)
				{
				break;
				}

			Console.WriteLine("The number is not even");
			}
			catch
			{
			Console.WriteLine("Invalid number!");
			}
		}
		Console.WriteLine("Even number entered {0}",n);





	}
}
