using System;

namespace Learn1.Other.Randomizers
{
    public static class Randomizer
    {
        private static Random random;
        public static void CheakRand()
        {
            if (random == null)
            {
                random = new Random();
            }
        }
        public static int RandNum(int min = int.MinValue, int max = int.MaxValue)
        {
            CheakRand();
            return random.Next(min, max);
        }
    }
}
