using System;
using System.Collections.Generic;

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
            } while (inputValue[0] != "END");
            
        }
    }
}
