using System;

public class Program
{
	public static void Main()
	{
		{
            var a = int.Parse(Console.ReadLine());
            Console.WriteLine(new string('*', a));

            for (int i = 0; i < a - 2; i++)
                Console.WriteLine(new string('*', 1) + new string(' ', a - 2) + new string('*', 1));

            Console.WriteLine(new string('*', a));
        }

	}
}
