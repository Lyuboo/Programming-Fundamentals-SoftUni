using System;

namespace HelloName
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputName = Console.ReadLine();
            WelcomeMessage(inputName);
        }

        private static void WelcomeMessage(string name)
        {
            Console.WriteLine($"Hello, {name}!");
        }
    }
}
