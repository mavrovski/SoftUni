using System;

public class Program
{
	public static void Main()
	{
			int n = int.Parse(Console.ReadLine());

			for (int row =0; row<=n ; row++)
			{
				var spaces = new String(' ',n-row);
				var stars = new String('*',row);

			Console.Write(spaces);
			Console.Write(stars);
			Console.Write(" | ");
			Console.Write(stars);
			Console.Write(spaces);
			Console.WriteLine();
			}

	}
}
