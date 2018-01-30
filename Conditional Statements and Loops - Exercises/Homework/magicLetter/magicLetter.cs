using System;

namespace magicLetter
{
    class magicLetter
    {
        static void Main(string[] args)
        {
            char inputLetterOne = char.Parse(Console.ReadLine());
            char inputLetterTwo = char.Parse(Console.ReadLine());
            char inputLetterThree = char.Parse(Console.ReadLine());
            for (char positionOne = inputLetterOne; positionOne <= inputLetterTwo; positionOne++)
            {
                for (char positionTwo = inputLetterOne; positionTwo <= inputLetterTwo; positionTwo++)
                {
                    for (char positionThree = inputLetterOne; positionThree <= inputLetterTwo; positionThree++)
                    {
                        if (positionOne != inputLetterThree && positionTwo != inputLetterThree && positionThree != inputLetterThree)
                        {
                            Console.Write($"{positionOne}{positionTwo}{positionThree} ");
                        }
                    }
                }
            }
        }
    }
}
