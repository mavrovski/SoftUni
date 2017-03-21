using System;

public class Program
{
	public static void Main()
	{
		string passWord = Console.ReadLine();
		string passWordKey = "s3cr3t!P@ssw0rd";


		if(passWord == passWordKey)

		{

		Console.WriteLine("Welcome");

		}
		else
		{


		Console.WriteLine("Wrong password!");

		}
	}
}
