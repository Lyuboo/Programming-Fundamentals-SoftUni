using System;

namespace World_In_Plural
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputWord = Console.ReadLine();
            string pluralWord = "";
            if (inputWord.EndsWith("y"))
            {
                string cutWord = inputWord.Remove(inputWord.Length - 1);
                pluralWord = cutWord + "ies";
            }
            else if (inputWord.EndsWith("o") || inputWord.EndsWith("ch") || inputWord.EndsWith("s") || inputWord.EndsWith("sh") || inputWord.EndsWith("x") || inputWord.EndsWith("z"))
            {
                pluralWord = inputWord + "es";
            }
            else
            {
                pluralWord = inputWord + "s";
            }
            Console.WriteLine(pluralWord);
        }
    }
}
