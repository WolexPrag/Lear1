using System;

namespace Lear1
{


    public readonly struct Pixel
    {
        private const char pixelChar = '█';
        public Pixel(int x,int y,ConsoleColor color)
        {
            X = x;
            Y = y;
            this.color = color;
        }
        public int X { get; }
        public int Y { get; }
        public ConsoleColor color { get; }
     
        public void Draw()
        {
#pragma warning disable CA1416 // Проверка совместимости платформы
            Console.SetCursorPosition(X, Y);
            Console.Write(pixelChar);
        }
        
        public void Clear()
        {
            Console.SetCursorPosition(X, Y);
            Console.Write(' ');
        }
    }
}
