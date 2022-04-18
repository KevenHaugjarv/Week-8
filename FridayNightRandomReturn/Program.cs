using System;

namespace FridayNightRandomReturn
{
    class Program
    {
        static void Main(string[] args)
        {
            string randomFood, randomDrink, randomMovie;
            string[] foods = { "chicken wings", "pizza", "sushi", "popcorn", "salat" };
            string[] drinks = { "apple juice", "coke", "fanta", "sprite" };
            string[] films = { "Rambo 1", "Rambo 2", "Rambo 3" };

            randomFood = PickRandomElementFromArray(foods);
            randomDrink = PickRandomElementFromArray(drinks);
            randomMovie = PickRandomElementFromArray(films);

            Console.WriteLine($"Täna õhtul sa sööd {randomFood} ja jood {randomDrink} ning vaatad {randomMovie}");

        }
        private static int GenerateRandomIndex(string[] someArray)
        {
            Random rnd = new Random();
            int randomIndex = rnd.Next(0, someArray.Length);
            return randomIndex;
        }


        private static string PickRandomElementFromArray(string[] someArray)
        {
            string randomElement = someArray[GenerateRandomIndex(someArray)];
            return randomElement;

        }
    }
}
