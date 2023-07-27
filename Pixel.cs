using System;

namespace Lear1
{


    public readonly struct Pixel : IGetPosition,IPrint
    {
        private const char pixelChar = '█';
        public Pixel(int x,int y,ConsoleColor color = ConsoleColor.White)
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
            Console.SetCursorPosition(X, Y); 
            Console.ForegroundColor = color;
            Console.Write(pixelChar);
        }
        
        public void Clear()
        {
            Console.SetCursorPosition(X, Y);

            Console.Write(' ');
        }

        public (int, int) GetPosition()
        {
            return (X,Y);
        }
    }
}
