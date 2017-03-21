using System;

public class Program
{
	public static void Main()
    {
        int h = int.Parse(Console.ReadLine());
        int y = int.Parse(Console.ReadLine());
        int x = int.Parse(Console.ReadLine());
        int x1 = 4 * h;
        int y1 = h;
        int x2 = h;
        int y2 = 2 * h;
        int x3 = h;
        int y3 = 0;
        int x4 = 0;
        int y4 = 3 * h;


        if ((x <= x1 && x >= x2 && y >= y1 && y <= y2) || (x <= x3 && x >= x4 && y >= y3 && y <= y4))
			//check inside
        {
            if (
                (((x == x1 || x == x2) && y >= y1 && y <= y2) || ((y == y1 || y == y2) && x <= x1 && x >= x2) ||    //Borders top rectangle
                ((x == x3 || x == x4) && y >= y3 && y <= y4) || ((y == y3 || y == y4) && x <= x3 && x >= x4))		    // Borders bottom rectangle
               )
            {
                if ((y > y1 && y < y2) && (x == x2 || x == x3)) //Shared line
                {
                    Console.WriteLine("Inside");
                }
                else
                {
                    Console.WriteLine("Border");
                }
            }
            else
            {
                Console.WriteLine("Inside");
            }
        }
        else
        {
            Console.WriteLine("Outside");
        }
	}
}
