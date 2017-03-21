using System;

public class Program
{
	public static void Main()
	{

		Console.WriteLine("Еnter a number in the range [1...100]:");
		int n = int.Parse(Console.ReadLine());




		while(n>100||n<=0)
		{
		 Console.WriteLine("Invalid number!");
		Console.WriteLine("Еnter a number in the range [1...100]:");
			n = int.Parse(Console.ReadLine());
		}

		Console.WriteLine("The number is: {0}",n);




	}

}
