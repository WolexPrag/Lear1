using System;
using static System.Console;
using System.Threading;
namespace Lear1
{
    internal class Program
    {
        public static Byrd byrd ;
        public static Tunel tunel;
        public static Random randomTunel = new Random();
        
        private static ConsoleColor BorderColor = ConsoleColor.DarkYellow;
        public static ConsoleColor ScoreColor = ConsoleColor.Blue;
        
        public static bool IsPlay;
        private static int MapWight = 35;
        private static int MapHeight = 25;
        public static int Score;
        public static int Gravitation;
        public static int HeightJumpPlayer;
        public static int CountPassFps;
        public static int EndWayTunel;
        public static int StartWayTunel;
        public static int SpeedGame = 50;

        private static void Main(string[] args)
        {
            Awake();
            Update();
        }
        public static void SetParamatersValue()
        {
            IsPlay = true;
            Score = 0;
            Gravitation = 1;
            HeightJumpPlayer = 3;
            CountPassFps = 0;
            EndWayTunel = 0;
            StartWayTunel = MapWight - 2;
        }
        public static void Awake()
        {
            SetWindowSize(MapWight, MapHeight);
            SetBufferSize(MapWight, MapHeight);
            CursorVisible = false;
            SetParamatersValue();
            DrawBorder();
            byrd = new Byrd(new Vector2D(MapWight / 2, MapHeight / 2), HeightJump: 3, HeightFall: Gravitation);
            tunel = new Tunel(GetStartWayTunel(tunel), MapHeight, HeightSpace: 9);
        }
        public static void Update()
        {
            do
            {
                
                Clear();
                Actions();
                Display();
                Thread.Sleep(SpeedGame);
            }
            while (IsPlay == true);
            
        }
        public static void Clear()
        {
            byrd.Clear();
            tunel.Clear();
        }
        public static void Display()
        {
            byrd.Draw();
            tunel.Draw();
            DisplayScore();
        }
        public static void Actions()
        {
            if (CountPassFps > 5)
            {
                PlayerAction();
                WorldAction(); 
            }
            CountPassFps++;
        }
        public static void DisplayScore()
        {
            SetCursorPosition(1,1);
            ForegroundColor = ScoreColor;
            Write($"Score: {Score}");
        }
        public static void PlayerAction()
        {
            Input();
            byrd.Fall();
            CheakByrd();
        }
        public static void WorldAction()
        {
            MoveTunel(ref tunel);
            CheakPositionTunel(ref tunel);
        }
        public static int Randomizer(int min, int max)
        {
            return randomTunel.Next(min, max);
        }
        public static void MoveTunel(ref Tunel tunel)
        {
            tunel.position.X = tunel.position.X - 1;
        }
        public static void CheakPositionTunel(ref Tunel tunel)
        {
            if (tunel.position.X <= EndWayTunel)
            {
                tunel.position = GetStartWayTunel(tunel);
                Score++;
            }
        }
        public static Vector2D GetStartWayTunel(Tunel tunel)
        {
            return new Vector2D((StartWayTunel),(Randomizer(tunel.HeightSpace, (MapHeight - tunel.HeightSpace))));
        }
        public static void CheakByrd()
        {
            if (byrd.position.Y >= MapHeight-1)
            {
                GameOver();
            }
            if (byrd.position.Y <= 1)
            {
                GameOver();
            }
            if (tunel.CheakCollision(byrd.position) == true)
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
            for (int y = 0; y < WindowHeight; y++)
            {
                for (int x = 0; x < WindowWidth; x++)
                {
                    new Pixel(x,y).Clear();
                }
            }
        }
        public static void GameOver()
        {
            ClearDisplay();
            IsPlay = false;
            SetCursorPosition(MapWight / 2, MapHeight / 2);
            WriteLine($"GameOver,\n Your Score {Score}");
            Stoper();
        }
        public static void Stoper() 
        {
            while (true)
            {
                Write("play again: ");
                string str = ReadLine();
                if (String.Equals(str, "no"))
                {
                    break;
                }
                if (String.Equals(str, "yes"))
                {
                    ClearDisplay();
                    Awake();
                    Update();
                }
            }
        }
    }
}
