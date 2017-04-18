using System;

public class Program
{
	public static void Main()
	{
		int n = int.Parse(Console.ReadLine());
    int m = int.Parse(Console.ReadLine());
    int Control = int.Parse(Console.ReadLine());

    int counter=0;
	int totalsum=0;
	int totalsum2=0;


      for (int i = 1; i<=n; i++)
      {
        for (int j = m; j>=1; j--)
        {

          totalsum=i*2+j*3;
		  totalsum2 +=totalsum;
          counter++;
		if(totalsum2>=Control)
			{
			break;
			}

		}
		if(totalsum2>=Control)
			{
			break;
			}


      }

		if (totalsum2>=Control)

          {
            Console.WriteLine("{0} moves",counter);
            Console.WriteLine("Score: {0} >= {1}",  totalsum2,Control);
          }
		else
		{
		 Console.WriteLine("{0} moves",counter);
		}

	}
}
