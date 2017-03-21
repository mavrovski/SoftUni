using System;

public class Program
{
	public static void Main()
	{
		string s = Console.ReadLine();
		int score = 0;

		for(int i = 0; i < s.Length;i++)

		{
		switch (s[i])

			{
			case 'a':
			score +=1;
			 break;
			case 'e':
			score +=2;
			 break;
			case 'i':
			score +=3;
			 break;
			case 'o':
			score +=4;
			 break;
			case 'u':
			score +=5;
			 break;
			}
		}


		Console.WriteLine(score);
	}
}
