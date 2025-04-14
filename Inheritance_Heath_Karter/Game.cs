using System;

namespace Inheritance_Heath_Karter
{
    class Game : IGenre
    {
        public string ESRB { get; set; }
        public string Genre { get; set; }
        public string Title { get; set; }

        public Game(string genre, string esrb, string title)
        {
            Genre = genre;
            ESRB = esrb;
            Title = title;
        }

        public void PlayGame()
        {
            Console.WriteLine("Game is Starting");
        }

        public string Describe()
        {
            return $"Game Title: {Title}, Genre: {Genre}, ESRB Rating: {ESRB}";
        }
    }
}
