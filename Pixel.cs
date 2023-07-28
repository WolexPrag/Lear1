using System;

namespace Lear1
{


    public readonly struct Pixel : IPrint
    {
        private const char pixelChar = '█';
        public Pixel(int x = 0, int y = 0, ConsoleColor color = ConsoleColor.White)
        {
            position = new Vector2D(x,y);
            this.color = color;
            
        }
        public readonly Vector2D position;
        public ConsoleColor color { get; }
     
        public void Draw()
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
