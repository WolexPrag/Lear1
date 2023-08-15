using System;
using System.Collections.Generic;

namespace Lear1
{


    public readonly struct Pixel : IDisplay
    {
        public static List<Pixel> pixels;
        private const char pixelChar = '█';
        public Pixel(Vector2D position, ConsoleColor color = ConsoleColor.White)
        {
            this.position = position;
            this.color = color;
        }
        public readonly Vector2D position;
        public ConsoleColor color { get; }
        public void Display()
        {
            Console.SetCursorPosition(position.X, position.Y); 
            Console.ForegroundColor = color;
            Console.Write(pixelChar);
            if (pixels == null)
            {
                pixels = new List<Pixel>() {this};
            }
            else
            {
                pixels.Add(this);
            }
        }
        public void Clear()
        {
            Console.SetCursorPosition(position.X, position.Y);
            Console.Write(' ');
            pixels.Remove(this);   
        }
        public static void ClearDisplay()
        {
            if (pixels == null)
            {
                return;
            }
            for (int i = 0; i < pixels.Count; i++)
            {
               pixels[i].Clear();
            }
        }
    }
}
