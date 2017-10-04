using System;

namespace _05BooleanVariable
{
    public class _05BooleanVariable
    {
        public static void Main(string[] args)
        {
            string toBoolean = Console.ReadLine();
            bool convert = Convert.ToBoolean(toBoolean);
            Console.WriteLine(convert ? "Yes" : "No");
        }

    }
}
