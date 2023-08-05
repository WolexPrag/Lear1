using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using System.Threading;

namespace Lear1
{
    class FlabbyByrd : World
    {
        protected Byrd byrd;
        protected Tunel tunel;
        protected ConsoleKey jumpKey;
        protected ConsoleKey exitKey;
        protected Random random;
        public FlabbyByrd(Vector2D mapSize, ConsoleKey JumpKey, ConsoleKey ExitKey, Vector2D gravitation,  int speedGame = 100) : base(mapSize: mapSize, gravitation: gravitation, speedGame: speedGame)
        {
            this.jumpKey = JumpKey;
            this.exitKey = ExitKey;
            random = new Random();
            this.gravitation = gravitation;
        }
        protected override void Awake()
        {
            base.Awake();
            byrd = new Byrd(mapSize/2);
        }
        protected override void Update()
        {
            WorldActions();
            PlayerActions();
            Rules();
        }
        protected override void Display()
        {
            base.Display();
            byrd.Display();
            tunel.Display();
        }

        protected void WorldActions()
        {
            if (tunel.position.X <= 3)
            {
                SpawnTunel(mapSize.X - 3, 1, mapSize.Y-1,1);
            }
            tunel.Move(new Vector2D(tunel.position.X - 1,tunel.position.Y));
        }

        protected void PlayerActions()
        {
            byrd.Fall(gravitation.Y);
            if (KeyAvailable)
            {
                InputActions();
            }
        }
        protected void InputActions()
        {
            ConsoleKeyInfo keyinf = ReadKey();
            if (keyinf.Key == jumpKey)
            {
                byrd.Jump(gravitation.Y * -3);
            }
            if (keyinf.Key == exitKey)
            {
                isPlay = false;
            }
        }
        protected void Rules()
        {
            if (1 >= byrd.position.Y || byrd.position.Y >= mapSize.Y - 1)
            {
                GameOver();
            }
            if (tunel.CheakCollision(byrd.position))
            {
                GameOver();
            }
        }
        protected int Randomize(int min, int max)
        {
            return random.Next(min, max);
        }
        protected void SpawnTunel(int X, int minY, int maxY, int tunelWeight)
        {
            tunel = new Tunel(new Vector2D(X, 0), new Vector2D(0, 0), new Vector2D(tunelWeight, Randomize(minY, maxY)));
        }
        protected void Exit()
        {
            isPlay = false;
        }
        protected void GameOver()
        {
            isPlay = false;
            Clear();
            SetCursorPosition(0,0);
            WriteLine("Game Over");
        }
    }
}
