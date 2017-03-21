using System;

public class Program
{
	public static void Main()
        {
            Console.Write("Add Rectangle's width: ");
            var width = double.Parse(Console.ReadLine());
            Console.Write("Add Rectangle's height: ");
            var height = double.Parse(Console.ReadLine());

            var aOfRectangle = width * height;


            Console.WriteLine("Area of Rectangle: " + aOfRectangle);
        }






}
