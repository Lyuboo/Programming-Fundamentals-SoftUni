using System;
using System.Collections.Generic;
using System.Linq;

namespace PhoneBook
{
    class PhoneBook
    {
        static void Main()
        {

            var phoneBook = new Dictionary<string, string>();
            string[] inputValue;

            do
            {
                inputValue = Console.ReadLine().Split(' ');
                if (inputValue[0] == "A")
                {
                    phoneBook[inputValue[1]] = inputValue[2];
                }
                if (inputValue[0] == "S")
                {
                    if (phoneBook.ContainsKey(inputValue[1]))
                    {
                        Console.WriteLine($"{inputValue[1]} -> {phoneBook[inputValue[1]]}");
                    }
                    else
                    {
                        Console.WriteLine($"Contact {inputValue[1]} does not exist.");
                    }
                }
                if (inputValue[0] == "ListAll")
                {
                    foreach (var contact in phoneBook.OrderBy(n => n.Key))
                    {
                        Console.WriteLine($"{contact.Key} -> {contact.Value}");
                    }
                }
            } while (inputValue[0] != "END");

        }
    }
}
