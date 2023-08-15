using System;

namespace Lear1
{
    public struct Byrd : IDisplay
    {
        public Vector2D position;
        public ConsoleColor color;
        public Byrd(Vector2D position,ConsoleColor color = ConsoleColor.Magenta)
        {
            this.position = position;
            this.color = color;
        }
        public void Fall(int Gravitation)
        {
            position.Y = position.Y + Gravitation;
        }
        public void Jump(int Height)
        {
            position.Y = position.Y + Height;
        }
        public void Display()
        {
            new Pixel(position,color).Display();
        }  
    }
}
