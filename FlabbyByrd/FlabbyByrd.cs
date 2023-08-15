using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using System.Threading;

namespace Lear1.FlabbyByrd
{
    class FlabbyByrd : World
    {
        protected Byrd byrd;
        protected List<Tunel> tunels;
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
