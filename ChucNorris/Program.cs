using System;
using System.IO;

namespace ChucNorris
{
    class Program
    {
        static void Main(string[] args)
        {
            string randoChucNorrisJoke;
            randoChucNorrisJoke = GetRandomFromFile("chuck.txt");


            Console.WriteLine($"Chuck Norri's nali: {randoChucNorrisJoke}");
        }
        private static int GenerateRandomIndex(string[] someArray)
        {
            Random rnd = new Random();
            int randomIndex = rnd.Next(0, someArray.Length);
            return randomIndex;
        }

        private static string GetRandomFromFile(string fileName)
        {
            string filePath = $@"C:\Users\...\Desktop\Kool\III aasta\Kevad\Programeerimine\N8 failid\Nädal 8 - failid-20220418\{fileName}";
            string[] dataFromFile = File.ReadAllLines(filePath);
            string randomElement = dataFromFile[GenerateRandomIndex(dataFromFile)];

            return randomElement;
        }
    }
}
