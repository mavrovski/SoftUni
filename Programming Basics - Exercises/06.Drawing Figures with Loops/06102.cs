using System;

public class Program
{
	public static void Main()
	{
		int n = int.Parse(Console.ReadLine());
    var leftRight = (n-1)/2;

      if (n==1)
      {
          Console.WriteLine("*");
      }
      else
      {
        for (int i=1; i<=(n-1/2); i++)
        {
        //draw up side

        Console.Write(new String('-',leftRight));
        Console.Write("*");
        var mid = n-2*leftRight-2;
            if (mid == 0)
             {
            Console.Write(new String('-',mid));
            Console.Write('*');
            }
        Console.WriteLine(new String('-',leftRight));
        leftRight --;

        }
        Console.WriteLine("*"+new String('-',n-2)+"*");
        leftRight++;
          for (int i = 0; i<(n-1)/2; i++)
          {
            Console.Write(new String('-'leftRight));
            Console.Write("*");
            var mid = n-2*leftRight-2;
                if (mid >=0)
                {
                  Console.Write(new String('-',mid));
                  Console.Write("*");
                }
          Console.WriteLine(new String('-',leftRight));
                leftRight++;
          }
      }


	}
}
