using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01Phonebook
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            var phonebook = new Dictionary<string, string>();
            var command = input[0];

            while (command != "END")
            {

                if (command == "A")
                {
                    var name = input[1];
                    var phone = input[2];
                    if (phonebook.ContainsKey(name))
                    {
                        phonebook[name] = phone;
                    }
                    else
                    {
                        phonebook.Add(name, phone);
                    }
                }
                else if (command == "S")
                {
                    var name = input[1];

                    if (phonebook.ContainsKey(name))
                    {
                        Console.WriteLine($"{name} -> {phonebook[name]}");
                    }
                    else
                    {
                        Console.WriteLine($"Contact {name} does not exist.");
                    }
                }
                input = Console.ReadLine().Split();
                command = input[0];
            }
            
        }
    }
}
