using System;

namespace Inheritance_Heath_Karter
{
    // Abstract class Game
    public abstract class Game
    {
        // Automatic properties
        public string ESRB { get; set; }
        public string Title { get; set; }

        // Constructor to initialize ESRB and Title
        public Game(string esrb, string title)
        {
            ESRB = esrb;
            Title = title;
        }

        // Concrete method that prints a starting message using the Title property
        public void PlayGame()
        {
            Console.WriteLine($"{Title} is Starting");
        }

        // Abstract method that must be overridden in derived classes
        public abstract string Describe();
    }
}
