using System;

namespace Inheritance_Heath_Karter
{
    // FPS class inherits from Game
    public class FPS : Game
    {
        // Constructor that uses base to initialize ESRB and Title
        public FPS(string esrb, string title) : base(esrb, title)
        {
        }

        // Override the Describe method
        public override string Describe()
        {
            return $"FPS Game Title: {Title}, ESRB Rating: {ESRB}";
        }
    }
}
