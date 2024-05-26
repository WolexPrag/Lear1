using System;
using System.Threading;

namespace Learn1.Game
{
    public abstract class World
    {
        protected bool IsPlay = true;
        protected Vector2D WinSize = new Vector2D(35, 25);

        public void Play()
        {
            Awake();
            Start();
        }
        protected virtual void Awake()
        {
            Console.SetWindowSize(WinSize.X, WinSize.Y);
            Console.SetBufferSize(WinSize.X, WinSize.Y);
        }
        protected virtual void Start()
        {
            do
            {
                Update();
                Display();
                Sleep(100);
                ClearDisplay();
            } while (IsPlay == true);
        }
        protected virtual void Update() { }
        protected virtual void Display() { }
        protected virtual void ClearDisplay() { }
        protected virtual void Sleep(int timeSleep)
        {
            Thread.Sleep(timeSleep);
        }
    }
}
