using System;
namespace Lear1
{
    internal class Program
    {
        public static void Main()
        {
            FlabbyByrd flabbyByrd = new FlabbyByrd(new Vector2D(35,25),ConsoleKey.Spacebar,ConsoleKey.Escape, new Vector2D (0,-1));
            flabbyByrd.Play();
        }
       

    }
}
