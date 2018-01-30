using System;

namespace caloriesCounters
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfIngredients = int.Parse(Console.ReadLine());
            int cheese = 500;
            int tomatoSauce = 150;
            int salami = 600;
            int pepper = 50;
            int totalCalories = 0;
            for (int counter = 0; counter < numberOfIngredients; counter++)
            {
                string inputIngredient = Console.ReadLine().ToLower();
                if (inputIngredient == "cheese")
                {
                    totalCalories = totalCalories + cheese;
                }
                else if (inputIngredient == "tomato sauce")
                {
                    totalCalories = totalCalories + tomatoSauce;
                }
                else if (inputIngredient == "salami")
                {
                    totalCalories = totalCalories + salami;
                }
                else if (inputIngredient == "pepper")
                {
                    totalCalories = totalCalories + pepper;
                }
                
            }
            Console.WriteLine($"Total calories: {totalCalories}");
        }
    }
}
