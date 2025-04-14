using System;

namespace Inheritance_Heath_Karter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create a Game object
            Game myGame = new Game("Adventure", "E10+", "Quest Runner");
            Console.WriteLine(myGame.Describe());
            myGame.PlayGame();

            Console.WriteLine();

            // Create a Movie object
            Movie myMovie = new Movie("Sci-Fi", "PG-13", "Galactic Voyage");
            Console.WriteLine(myMovie.Describe());
            myMovie.PlayMovie();

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
