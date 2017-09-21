using System;

namespace _03Employee_Data
{
    public class _03Employee_Data
    {
        public static void Main(string[] args)
        {   
            string name = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            int employee = int.Parse(Console.ReadLine());
            double salary = double.Parse(Console.ReadLine());

            Console.WriteLine($"Name: {name}\nAge: {age}\nEmployee ID: {employee:D8}\nSalary: {salary:F2}");
        }
    }
}
