using System;
using static System.Console;
using System.Threading;
namespace Lear1
{
    internal class Program
    {
        public static bool IsPlay;
        public static Byrd byrd ;
        private const int MapWight = 35;
        private const int MapHeight = 25;
        private static ConsoleColor BorderColor = ConsoleColor.DarkYellow;
        public static ConsoleColor ScoreColor = ConsoleColor.Blue;
        public static Random randomTunel = new Random();
        public static Tunel tunel;
        public static int Score;
        public static int SpeedTunel;
        private static void Main(string[] args)
        {

            ReDrawAll();
            Update();
            
        }
        public static void Update()
        {
            IsPlay = true;
            byrd = new Byrd(MapWight / 2, MapHeight / 2);
            tunel = new Tunel(0, 0, MapHeight);
            int CountPassFps = 0;
            Score = 0;
            do
            {
                if (MapHeight != WindowHeight || MapWight != WindowWidth)
                {
                    ReDrawAll();
                }
                if (CountPassFps > 5) 
                {
                    
                    PlayerAction();

                    if (!(MapHeight < 15 || MapWight < 25))
                    {
                        WorldAction(CountPassFps);
                    }
                }
                Thread.Sleep(100);
                CountPassFps++;
                DisplayScore();
            }
            while (IsPlay == true);
           
        }
        
        public static void DisplayScore()
        {
            SetCursorPosition(1,1);
            ForegroundColor = ScoreColor;
            Write($"Score: {Score}");
        }
        public static void PlayerAction()
        {
            byrd.Clear();
            Input();
            byrd.Fall();
            CheakByrd();
            byrd.Draw();
        }
        public static void WorldAction(int CountPassFps)
        {
            tunel.Clear();
            if (tunel.X < byrd.X - 7 && CountPassFps > 15)
            {
                ReSpawnTunel();
            }
            if (CountPassFps > 20)
            {
                MoveTunel(1);
                tunel.Draw();
            }
            
            
        }
        public static void ReSpawnTunel()
        {
            tunel.Y = randomTunel.Next(1,MapHeight-tunel.HeightSpace);
            tunel.X = byrd.X + 7;
            Score++;
        }
        public static void MoveTunel(int howFast)
        {
            tunel.X = tunel.X - howFast;
        }
        public static void GameOver()
        {
            IsPlay = false;
            SetCursorPosition(MapWight/2,MapHeight/2);
            WriteLine($"GameOver,\n Your Score {Score}");
            Stoper();
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
            if (!(byrd.Y > tunel.Y && byrd.Y < tunel.Y + tunel.HeightSpace)&&tunel.X == byrd.X)
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
        public static void ClearDisplay()
        {
            for (int y = 0; y < MapHeight; y++)
            {
                for (int x = 0; x < MapWight; x++)
                {
                    new Pixel(x,y).Clear();
                }
            }
        }
        public static void ReDrawAll()
        {
            SetWindowSize(MapWight, MapHeight);
            SetBufferSize(MapWight, MapHeight);
            ClearDisplay();
            DrawBorder();
            CursorVisible = false;
        }
        public static void Stoper() 
        {
            
            while (true)
            {
                if (MapHeight != WindowHeight || MapWight != WindowWidth)
                {
                    ReDrawAll();
                }
                Write("play again: ");
                string str = ReadLine();
                if (String.Equals(str, "no"))
                {
                    break;
                }
                if (String.Equals(str, "yes"))
                {
                    ReDrawAll();
                    DrawBorder();
                    Update();
                }
            }
            
 
        }
    }
}
