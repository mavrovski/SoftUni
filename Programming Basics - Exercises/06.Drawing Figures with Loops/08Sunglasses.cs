using System;

public class Program
{
	public static void Main()
	{
    	int n = int.Parse(Console.ReadLine());


        //up
      Console.Write(new String('*',2*n));
      Console.Write(new String(' ',n));
      Console.WriteLine(new String('*',2*n));
      //lef side
      for (int row =2; row<=n-1; row++)
      {
        Console.Write('*');
        Console.Write(new String('/',(2*n)-2));
        Console.Write('*');

        // MIDLE
        if ((row-2) == (n-1)/2-1)
        {
          Console.Write(new String('|',n));
        }
        else
        {
          Console.Write(new String(' ',n));


        }

      //rigt side
          Console.Write('*');
          Console.Write(new String('/',(2*n)-2));
          Console.WriteLine('*');

      }






        //bottom
      Console.Write(new String('*',2*n));
      Console.Write(new String(' ',n));
      Console.WriteLine(new String('*',2*n));
	}
}
