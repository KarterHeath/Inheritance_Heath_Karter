using System;

namespace Inheritance_Heath_Karter
{
    public interface IGenre
    {
        string ESRB { get; set; }
        string Genre { get; set; }
        string Title { get; set; }

        string Describe();
    }
}
