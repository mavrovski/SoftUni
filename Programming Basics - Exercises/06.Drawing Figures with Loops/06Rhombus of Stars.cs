using System;

public class Program
{
	public static void Main()
	{
	 int n = int.Parse(Console.ReadLine());

   //uP
   for (int row = 1; row<=n; row++)
   {
     for (int col = 1 ; col<=n-row; col++)
     {
       Console.Write(" ");
     }
     Console.Write("*");
      for (int col = 1; col<row; col++)
      {
        Console.Write(" *");
      }
      Console.WriteLine();
   }
   //down
   for (int row = n-1; row>=1; row--)
   {
      for (int col = n-row ; col>=1; col--)
      {
        Console.Write(" ");
      }
      for (int col = 1; col<=row; col++)
      {
        Console.Write("* ");
      }
      Console.WriteLine();
   }




	}
}
