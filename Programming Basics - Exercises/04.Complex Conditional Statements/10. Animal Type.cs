using System;

public class Program
{
	public static void Main()
	{

	string Animal = Console.ReadLine();
	string Type = "";

	switch (Animal)
	{
	case "dog":
	Type = "mammal";
	break;
	case "crocodile":
	Type = "reptile";
	break;
	case "tortoise":
	Type = "reptile";
	break;
	case "snake":
	Type = "reptile";
	break;
	default:
	Type= "unknown";
	break;
	}
	Console.WriteLine(Type);



	}
}
