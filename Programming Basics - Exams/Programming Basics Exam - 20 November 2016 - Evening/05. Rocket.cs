using System;

public class Program
{
	public static void Main()
	{
		var n = int.Parse(Console.ReadLine());
		var leftRight=0;
		var middle=0;
		//top
		leftRight=(3*n-2)/2;
		middle=0;
		for(int i=1;i<=n;i++)
		{
		Console.WriteLine("{0}/{1}\\{0}",new string('.',leftRight),new string(' ',middle));
		leftRight--;
		middle+=2;
		}

		//ring
		leftRight = n/2;
		middle=2*n;
		Console.WriteLine("{0}{1}{0}",new string('.',leftRight),new string('*',middle));




		//middle
		for(int i=1;i<=(n*2);i++)
		{

		leftRight=n/2;
		middle=2*n-2;
		Console.WriteLine("{0}|{1}|{0}",new string('.',leftRight),new string('\\',middle));
		}



		//bottom
		leftRight=n/2;
		middle=2*n-2;
		for(int i=1;i<=(n/2);i++)
		{

		Console.WriteLine("{0}/{1}\\{0}",new string('.',leftRight),new string('*',middle));
		leftRight--;
		middle+=2;
		}
	}
}
