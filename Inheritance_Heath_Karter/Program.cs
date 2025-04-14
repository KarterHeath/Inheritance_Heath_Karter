using System;

namespace Inheritance_Heath_Karter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create an FPS game object and pass in the title and ESRB rating
            FPS myFPSGame = new FPS("M", "Call of Battle");

            // Call Describe and print the result
            Console.WriteLine(myFPSGame.Describe());

            // Start the game
            myFPSGame.PlayGame();

            // Pause the console so it stays open
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
