using System;
using static System.Console;

namespace Lear1
{
    internal class Program
    {
        private const int MapWight = 30;
        private const int MapHeight = 20;
        private const ConsoleColor BorderColor = ConsoleColor.Gray;

        private static void Main(string[] args)
        {
            SetWindowSize(MapWight, MapHeight);

            SetBufferSize(MapWight, MapHeight);

            CursorVisible = false;

            DrawBorder();
            ReadKey();
        }

        private static void DrawBorder()
        {
            for (int i = 0; i < MapWight; i++)
            {
                new Pixel(i, 0, BorderColor).Draw();
                new Pixel(i, MapHeight - 1, BorderColor).Draw();
            }
            for (int i = 0; i < MapHeight; i++)
            {
                new Pixel(0, i, BorderColor).Draw();
                new Pixel(MapWight - 1, i, BorderColor).Draw();
            }
        }
    }
}
