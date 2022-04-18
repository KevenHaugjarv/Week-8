using System;
using System.IO;

namespace PickFromFile
{
    class Program
    {
        static void Main(string[] args)
        {
            string randomFood, randomDrink, randomMovie;
            randomFood = GetRandomFromFile("foods.txt");
            randomDrink = GetRandomFromFile1("drinks.txt");
            randomMovie = GetRandomFromFile2("movies.txt");

            Console.WriteLine($"Täna õhtul sa sööd {randomFood} ja jood {randomDrink} ning vaatad {randomMovie}");

        }

        private static int GenerateRandomIndex(string[] someArray)
        {
            Random rnd = new Random();
            int randomIndex = rnd.Next(0, someArray.Length);
            return randomIndex;
        }

        private static string GetRandomFromFile(string fileName)
        {
            string filePath = $@"C:\Users\kasutaja\Desktop\Kool\III aasta\Kevad\Programeerimine\N8 failid\Nädal 8 - failid-20220418\{fileName}";
            string[] dataFromFile = File.ReadAllLines(filePath);
            string randomElement = dataFromFile[GenerateRandomIndex(dataFromFile)];

            return randomElement;

        }
        private static string GetRandomFromFile1(string fileName)
        {
            string filePath = $@"C:\Users\kasutaja\Desktop\Kool\III aasta\Kevad\Programeerimine\N8 failid\Nädal 8 - failid-20220418\{fileName}";
            string[] dataFromFile = File.ReadAllLines(filePath);
            string randomElement = dataFromFile[GenerateRandomIndex(dataFromFile)];

            return randomElement;
        }
        private static string GetRandomFromFile2(string fileName)
        {
            string filePath = $@"C:\Users\kasutaja\Desktop\Kool\III aasta\Kevad\Programeerimine\N8 failid\Nädal 8 - failid-20220418\{fileName}";
            string[] dataFromFile = File.ReadAllLines(filePath);
            string randomElement = dataFromFile[GenerateRandomIndex(dataFromFile)];

            return randomElement;
        }




    }
}



    
