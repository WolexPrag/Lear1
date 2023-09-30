using System;

namespace Learn1.Game
{
    public interface IDisplay
    {
        public void Display();
        public void Clear();
    }
    public readonly struct Pixel : IDisplay
    {
        private const char pixelChar = '█';
        private readonly Vector2D position;
        private ConsoleColor color { get; }
        public Pixel(Vector2D position, ConsoleColor color = ConsoleColor.White)
        {
            this.position = position;
            this.color = color;
        }
        public void Display() 
        {
            Console.SetCursorPosition(position.X, position.Y); 
            Console.ForegroundColor = color;
            Console.Write(pixelChar);
        }
        public void Clear()
        {
            Console.SetCursorPosition(position.X, position.Y);
            Console.Write(' ');   
        }
    }
}
