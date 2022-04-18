using System;

namespace FunctionsReturnAndArraysForFile
{
    class Program
    {
        static void Main(string[] args)
        {
            DisplayRandomFood();
            DisplayRandomDrink();
            DisplayRandomMovie();
        }
        private static void DisplayRandomFood()
        {
            string[] foods = { "chicken wings", "pizza", "sushi", "popcorn", "salat" };
            Random rnd = new Random();
            int randomIndex = rnd.Next(0, foods.Length);
            string randomFood = foods[randomIndex];
            Console.WriteLine($"Computer piced: {randomFood}");



        }
        private static void DisplayRandomDrink()
        {
            string[] drinks = { "apple juice", "coke", "fanta", "sprite" };
            Random rnd = new Random();
            int randomIndex = rnd.Next(0, drinks.Length);
            string randomdrink = drinks[randomIndex];
            Console.WriteLine($"Computer piced: {randomdrink}");
        }
        private static void DisplayRandomMovie()
        {
            string[] films = { "Rambo 1", "Rambo 2", "Rambo 3" };
            Random rnd = new Random();
            int randomIndex = rnd.Next(0, films.Length);
            string randomfilm = films[randomIndex];
            Console.WriteLine($"Computer piced: {randomfilm}");
        }

    }
}
