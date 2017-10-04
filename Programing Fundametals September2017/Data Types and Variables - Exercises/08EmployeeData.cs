using System;

namespace _08.EmployeeData
{
    public class _08EmployeeData
    {
        public static void Main(string[] args)
        {

            string firstName = Console.ReadLine();
            string secondName = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            char gender = char.Parse(Console.ReadLine());
            decimal personalId = decimal.Parse(Console.ReadLine());
            int uniqueEmployeeNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("First name: {0}", firstName);
            Console.WriteLine("Last name: {0}", secondName);
            Console.WriteLine("Age: {0}", age);
            Console.WriteLine("Gender: {0}", gender);
            Console.WriteLine("Personal ID: {0}", personalId);
            Console.WriteLine("Unique Employee number: {0}", uniqueEmployeeNumber);

        }
    }
}
