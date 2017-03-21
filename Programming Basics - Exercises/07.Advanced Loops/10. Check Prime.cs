using System;

public class Program
{
	public static void Main()
	{
	int n = int.Parse(Console.ReadLine());
	bool prime = true;

	if(n<2)
	{
	prime=false;

	}
	else
	{
		for(int i =2;i<=Math.Sqrt(n);i++)
		{
		if(n % i==0)
			{
			prime=false;
			break;
			}
		}

	}
	if(prime)
	{
	Console.WriteLine("Prime");
	}
	else Console.WriteLine("Not Prime");

	}
}
