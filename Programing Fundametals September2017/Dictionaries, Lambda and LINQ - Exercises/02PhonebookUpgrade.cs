using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02PhonebookUpgrade
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            var phonebook = new SortedDictionary<string, string>();
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
                if (command == "ListAll")
                {
                    foreach (var phone in phonebook)
                    {
                        Console.WriteLine("{0} -> {1}",phone.Key,phone.Value);
                    }
                }
                input = Console.ReadLine().Split();
                command = input[0];
            }
        }
    }
}
