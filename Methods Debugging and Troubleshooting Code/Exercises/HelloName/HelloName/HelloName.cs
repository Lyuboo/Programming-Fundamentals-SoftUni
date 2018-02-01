using System;

namespace HelloName
{
    class HelloName
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
