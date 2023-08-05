using System;
using System.Threading;

namespace Lear1
{
    public abstract class World
    {
        protected bool isPlay;
        protected int speedGame;
        protected Vector2D gravitation;
        protected Vector2D mapSize;
        public World(Vector2D mapSize,Vector2D gravitation, int speedGame = 100)
        {
            this.mapSize = mapSize;
            this.gravitation = gravitation;
            this.speedGame = speedGame;
        }
        public virtual void Play() 
        { 
            Awake();
            Start();
        }
        protected virtual void Awake()
        { 
            Console.SetWindowSize(mapSize.X, mapSize.Y);
            Console.SetBufferSize(mapSize.X, mapSize.Y);
            Console.CursorVisible = false;
            isPlay = true;
        }
        protected virtual void Start()
        {
            do
            {
                Update();
                Display();
                Sleep(milisecod:speedGame);
                ClearDisplay();
            } while (isPlay == true);
        }
        protected virtual void Update(){}
        protected virtual void ClearDisplay()
        {
            Pixel.ClearDisplay();
        }
        protected virtual void Display(){}
        protected virtual void Sleep(int milisecod)
        {
            Thread.Sleep(milisecod);
        }
    }
}
