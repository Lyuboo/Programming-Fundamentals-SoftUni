using System;

namespace BooleanVariable
{
    class BooleanVariable
    {
        static void Main(string[] args)
        {
            string InputBool = Console.ReadLine();
            if (Convert.ToBoolean(InputBool))
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
