using System;

namespace FridayNightRandom
{
    class Program
    {
        static void Main(string[] args)
        {
            DisplayRandomFood();
            DisplayRandomDrink();
            DisplayRandomMovie();
        }
        private static int GenerateRandomIndex(string[] someArray)
        {
            Random rnd = new Random();
            int randomIndex = rnd.Next(0, someArray.Length);
            return randomIndex;
        }

        private static void DisplayRandomFood()
        {
            string[] foods = { "chicken wings", "pizza", "sushi", "popcorn", "salat" };
            
            Console.WriteLine($"Computer piced: {foods[GenerateRandomIndex(foods)]}");



        }
        private static void DisplayRandomDrink()
        {
            string[] drinks = { "apple juice", "coke", "fanta", "sprite" };
            Random rnd = new Random();
           
            Console.WriteLine($"Computer piced: {drinks[GenerateRandomIndex(drinks)]}");
        }
        private static void DisplayRandomMovie()
        {
            string[] films = { "Rambo 1", "Rambo 2", "Rambo 3" };
            Random rnd = new Random();
            
            Console.WriteLine($"Computer piced: {films[GenerateRandomIndex(films)]}");
        }
    }
}
