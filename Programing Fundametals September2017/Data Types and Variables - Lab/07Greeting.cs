using System;

namespace _07.Greeting
{
    public class _07Greeting
    {
        public static void Main(string[] args)
    {

            string firstname = Console.ReadLine();
            string secondName = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine($"Hello, {firstname} {secondName}. You are {age} years old");
    }
}
}
