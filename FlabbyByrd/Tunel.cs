using System;
using System.Collections.Generic;

namespace Lear1
{
    public struct Tunel : IDisplay,ICheakCollison
    {
        public Vector2D position;
        public Vector2D spaceMinPosition;
        public Vector2D spaceMaxPosition;
        public ConsoleColor color;
        public Tunel(Vector2D position,Vector2D spaceMinPosition,Vector2D spaceMaxPosition,ConsoleColor colorTunel = ConsoleColor.Green)
        {
            this.position = position;
            this.spaceMinPosition = spaceMinPosition;
            this.spaceMaxPosition = spaceMaxPosition;
            this.color = colorTunel;
        }
        public bool CheakCollision(Vector2D vector)
        {
            return InFullSpace(vector);
        }
        public bool InFullSpace(Vector2D vector)
        {
            if (spaceMinPosition.X <= vector.X && spaceMaxPosition.X >= vector.X)
            {
                if (spaceMinPosition.Y <= vector.Y && spaceMaxPosition.Y >= vector.Y)
                {
                    return true;
                }
            }
            return false;
        }
        public void Display()
        {
            for (int x = spaceMinPosition.X; x <= spaceMaxPosition.X; x++)
            {
                for (int y = spaceMinPosition.Y; y <= spaceMaxPosition.Y; y++)
                {
                    if (InFullSpace(new Vector2D(x,y)))
                    {
                        new Pixel(new Vector2D(x: (x + position.X), y: (y + position.Y)),color).Display();
                    }
                }
            }
        }
        public void Move(Vector2D position)
        {
            this.position = position;
        }
    }
}
