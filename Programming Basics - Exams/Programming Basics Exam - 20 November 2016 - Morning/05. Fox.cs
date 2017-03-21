using System;

public class Program
{
	public static void Main()
	{
		var n = int.Parse(Console.ReadLine());
    var stars = 1;
    var dashes = 2*n+3-4;
    var stars2=n/2;
    var stars3=n;
    //Top

		for (int row=1; row<=n; row++)
    {

		  Console.Write("{0}\\{1}/{0}",new string ('*',stars),new string ('-',dashes));
			  stars++;
			  dashes-=2;

      Console.WriteLine();
	   }
     //middle
     for (int row=1; row<=n/3; row++)
     {

     Console.Write("|{0}\\{1}/{0}|",new string ('*',stars2),new string ('*',stars3));
      stars2++;
      stars3-=2;
      Console.WriteLine();
     }
     //bottom
		dashes=1;
		stars=2*n+3-4;
     for (int row=1; row<=n; row++)
     {

 		  Console.Write("{0}\\{1}/{0}",new string ('-',dashes),new string ('*',stars));

 		dashes++;
        stars-=2;
       Console.WriteLine();
 	   }

	}
}
