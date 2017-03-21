using System;

public class Program
{
	public static void Main()
	{
		int n = int.Parse(Console.ReadLine());

		var stars= 1;

		if (n %2==0)
		{
			stars = stars+1;//stars ++
		}
		//prin roof
		for (int i =0; i<(n+1)/2; i++)
		{
			var padding = (n-stars)/2;
			Console.Write(new String('-',padding));
			Console.Write(new String('*',stars));
			Console.WriteLine(new String('-',padding));
			stars +=2;
		}
		//Body
		for (int i = 0; i<n/2; i++)
		 {
			 Console.Write("|");
			 Console.Write(new String('*',n-2));
			 Console.WriteLine("|");
		 }


	}
}
