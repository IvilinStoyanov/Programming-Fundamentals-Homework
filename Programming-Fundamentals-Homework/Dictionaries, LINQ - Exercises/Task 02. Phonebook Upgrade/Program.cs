using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_01_Phonebook
{
    class Program
    {
        static void Main(string[] args)
        {
            var command = Console.ReadLine();
            var phoneBook = new SortedDictionary<string, string>();

            while (command != "END")
            {
                var commandList = command
                    .Split(' ')
                    .ToList();
                var instruction = commandList[0];
                var name = commandList.Count() > 1 ?
                    commandList[1] :
                    string.Empty;

                if (instruction == "A")
                {
                    AddPhoneNumber(phoneBook, commandList, name);
                }
                if (instruction == "S")
                {
                    SearchPhoneNumberByName(phoneBook, name);
                }
                if (instruction == "ListAll")
                {
                    foreach (var item in phoneBook)
                    {
                        Console.WriteLine($"{item.Key} -> {item.Value}");
                    }
                }
                command = Console.ReadLine();
            }
        }

        private static void SearchPhoneNumberByName(SortedDictionary<string, string> phoneBook, string name)
        {
            Console.WriteLine(
            phoneBook.ContainsKey(name) ?
            $"{name} -> {phoneBook[name]}" :
            $"Contact {name} does not exist.");
        }

        static void AddPhoneNumber(SortedDictionary<string, string> phoneBook,
            List<string> commandList, string name)
        {
            var phoneNumber = commandList[2];
            if (!phoneBook.ContainsKey(name))
            {
                phoneBook[name] = string.Empty;
            }
            phoneBook[name] = phoneNumber;
        }

    }
}
