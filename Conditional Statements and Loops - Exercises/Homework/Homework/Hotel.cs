using System;

namespace Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int nightsCount = int.Parse(Console.ReadLine());
            double studioPrice = 0;
            double doubleRoomPrice = 0;
            double suitePrice = 0;
            if (month == "May" || month == "October")
            {
                if (nightsCount > 7)
                {
                    studioPrice = 0.95 * 50;
                }
                else
                {
                    studioPrice = 50;
                }
                doubleRoomPrice = 65;
                suitePrice = 75;
            }
            if (month == "June" || month == "September")
            {
                studioPrice = 60;
                if (nightsCount > 14)
                {
                    doubleRoomPrice = 0.9 * 72;
                }
                else
                {
                    doubleRoomPrice = 72;
                }
                suitePrice = 82;
            }
            if (month == "July" || month == "August" || month == "December")
            {
                studioPrice = 68;
                doubleRoomPrice = 77;
                if (nightsCount > 14)
                {
                    suitePrice = 0.85 * 89;
                }
                else
                {
                    suitePrice = 89;
                }
            }
            if (nightsCount > 7 && (month == "September" || month == "October"))
            {
                Console.WriteLine($"Studio: {studioPrice * (nightsCount - 1)} lv.");
            }
            else
            {
                Console.WriteLine($"Studio: {studioPrice * nightsCount} lv.");
            }
            Console.WriteLine($"Double: {doubleRoomPrice * nightsCount} lv.");
            Console.WriteLine($"Suite: {suitePrice * nightsCount} lv.");
        }
    }
}
