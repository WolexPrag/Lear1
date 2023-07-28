using System;

namespace Lear1
{
    internal struct Tunel : IPrint,ICheakCollison

    {
        public Vector2D position;
        public int Weight;
        public int HeightSpace;
        public ConsoleColor Color;
        public int MapHeight;
        public Tunel(Vector2D position, int? MapHeight = null,int Weight = 1,int HeightSpace = 11,ConsoleColor Color = ConsoleColor.Green)
        {
            this.position = position;
            this.Weight = Weight;
            this.HeightSpace = HeightSpace;
            this.Color = Color;
            this.MapHeight = MapHeight??(Console.WindowHeight);
        }
        public bool CheakCollision(Vector2D other)
        {
            if (other.X >= position.X && (Weight + position.X) >= other.X)
            {
                if (!(other.Y > position.Y && other.Y < position.Y + HeightSpace))
                {
                    return true;
                }
            }
            return false;
        }
        public void Clear()
        {
            for (int x = position.X; x < (Weight + position.X); x++)
            {
                for (int y = 1; y < MapHeight - 1; y++)
                {
                    if (!(y > position.Y && y < position.Y + HeightSpace))
                    {
                        new Pixel(x: x, y: y, color: Color).Clear();
                    }

                }
            }
        }
        public void Draw()
        {
            for (int x = position.X; x < (Weight + position.X) ; x++)
            {
                for (int y = 1; y < MapHeight - 1; y++)
                {
                    if (!(y > position.Y && y < position.Y + HeightSpace))
                    {
                        new Pixel(x: x, y: y, color: Color).Draw();
                    }

                }
            }
        }
    }
}
