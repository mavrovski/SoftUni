using System;

public class Program
{
	public static void Main()
	{

        int n = int.Parse(Console.ReadLine());
        int[] List= new int[n];
        int max = 0;
        int sum = 0;
        for (int i = 0; i < n; i++)
        {
            List[i] = int.Parse(Console.ReadLine());
            max = Math.Max(List[i], max);
            sum +=List[i];
        }
        sum -= max;
        if (max == sum)
        {
            Console.WriteLine("Yes Sum = {0}", max);
        }
        else
        {
            Console.WriteLine("No Diff = {0}",Math.Abs(max - sum));
        }
	}
}
