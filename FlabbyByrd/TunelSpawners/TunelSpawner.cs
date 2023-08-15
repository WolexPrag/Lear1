using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lear1.FlabbyByrd
{
    public abstract class TunelSpawner
    {
        public readonly Random random;
        public int max;
        public int min;
        public int x;
        protected int Randomize(int min, int max)
        {
            return random.Next(min, max);
        }
        protected Tunel SpawnTunelUp(int X, int minY, int maxY, int tunelWeight)
        {
            return new Tunel(new Vector2D(X, 0), new Vector2D(0, 0), new Vector2D(tunelWeight, Randomize(minY, maxY)));
        }
        protected Tunel SpawnTunelDown(int X, int minY, int maxY, int tunelWeight)
        {
            return new Tunel(new Vector2D(X, 0), new Vector2D(0, Randomize(minY, maxY)), new Vector2D(tunelWeight - 1, 0));
        }
    }
}
