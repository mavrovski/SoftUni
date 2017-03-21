using System;

public class Program
{
	public static void Main()
	{
		 int n = int.Parse(Console.ReadLine());

		 	//Row #1
	Console.Write("+");
	for (int col = 1; col<n-1; col++)
			{
				Console.Write(" -");
			}
			Console.WriteLine(" +");
	//MIDLE
	for (int row =1 ; row<n-1; row++)
 		{
	 Console.Write("|");
		for (int col=1; col<=n-1; col++)
			{
			Console.Write(" -");
			}
		Console.WriteLine("|");
		}
		//Row last
Console.Write("+");
for (int col = 1; col<n-1; col++)
		{
			Console.Write(" -");
		}
		Console.WriteLine(" +");
	}
}
