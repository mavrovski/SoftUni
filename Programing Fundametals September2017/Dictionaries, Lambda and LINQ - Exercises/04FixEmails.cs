using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04FixEmails
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            
            var nameEmailDictonary = new Dictionary<string, string[]>();

            while(name != "stop")
            {
                string[] email = Console.ReadLine().Split('.');
                if (email[1] != "us" && email[1] != "uk")
                {
                    nameEmailDictonary.Add(name, email);
                }
                name = Console.ReadLine();
            }
            foreach (var person in nameEmailDictonary)
            {
                Console.WriteLine($"{person.Key} -> {String.Join(".", person.Value)}");
            }
        }
    }
}
