using System;
using static System.Console;
using System.Threading;
namespace Lear1
{
    internal class Program
    {
        public static bool IsPlay = true;
        public static Byrd byrd = new Byrd(MapWight / 2, MapHeight /2);
        private const int MapWight = 15;
        private const int MapHeight = 9;
        private const ConsoleColor BorderColor = ConsoleColor.Gray;

        private static void Main(string[] args)
        {
            SetWindowSize(MapWight, MapHeight);

            SetBufferSize(MapWight, MapHeight);

            CursorVisible = false;
            

            DrawBorder();
            Update();
            ReadKey();
        }
        public static void Update()
        {
            int CounPassFps = 0;
            do
            {
                byrd.Clear();
                Input();
                byrd.Fall();
                CheakByrd();
                byrd.Draw();
                Thread.Sleep(200);
                
                CounPassFps++;
                WriteLine(CounPassFps);
            }
            while (IsPlay == true);
           
        }
        public static void GameOver()
        {
            IsPlay = false;
            WriteLine("GameOver");
        }
        public static void CheakByrd()
        {
            if (byrd.Y>MapHeight - 2)
            {
                GameOver();
            }
            if (byrd.Y < 2)
            {
                GameOver();
            }
        }
        public static void Input()
        {
            if (!KeyAvailable) return;
            ConsoleKey key = ReadKey(true).Key;
            switch (key)
            {
                case ConsoleKey.Spacebar:
                    byrd.Jump();
                    break;
                case ConsoleKey.Escape:
                    IsPlay = false;
                    break;
            }

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
