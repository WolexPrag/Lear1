using System.Collections.Generic;
using static System.Console;

namespace Lear1
{
    public struct Vector2D
    {

        public Vector2D(int x,int y)
        {
            _X = x;
            _Y = y;
        }
        private int _X;
        public int X
        {
            get { return _X; }
            set 
            {
                _X = CheakX(value);
            }
        }
        private int _Y;
        public int Y
        {
            get { return _Y; }
            set 
            {
                _Y = CheakY(value);

            }
        }
        public int CheakX(int x)
        {

            if (x < 0)
            {
                x = 0;

            }
            else if (x > WindowWidth)
            {
                x = WindowWidth;
            }
            
            return x;
        }
        public int CheakY(int y)
        {
            if (y < 0)
            {
                y = 0;

            }
            else if (y > WindowWidth)
            {
                y = WindowWidth;
            }
            return y;
        }
        public static Vector2D operator +(Vector2D vector1,Vector2D vector2)
        {
            return new Vector2D(vector1.X + vector2.X, vector1.Y + vector2.Y);
        }
        public static Vector2D operator -(Vector2D vector1, Vector2D vector2)
        {
            return new Vector2D(vector1.X - vector2.X, vector1.Y - vector2.Y);
        }
        public static Vector2D operator *(Vector2D vector1, Vector2D vector2)
        {
            return new Vector2D(vector1.X * vector2.X, vector1.Y * vector2.Y);
        }
        public static Vector2D operator /(Vector2D vector1, Vector2D vector2)
        {
            return new Vector2D(vector1.X / vector2.X, vector1.Y / vector2.Y);
        }
        public static Vector2D operator *(Vector2D vector1, int value)
        {
            return new Vector2D(vector1.X * value, vector1.Y * value);
        }
        public static Vector2D operator /(Vector2D vector1, int value)
        {
            return new Vector2D(vector1.X / value, vector1.Y / value);
        }
        public static bool operator ==(Vector2D vector1, Vector2D vector2)
        {
            return (vector1.X == vector2.X) && (vector1.Y == vector2.Y);
        }
        public static bool operator !=(Vector2D vector1, Vector2D vector2)
        {
            return (vector1.X != vector2.X) && (vector1.Y != vector2.Y);
        }
        public static (bool,bool) operator >(Vector2D vector1, Vector2D vector2)
        {
            return ((vector1.X > vector2.X), (vector1.Y > vector2.Y));
        }
        public static (bool, bool) operator <(Vector2D vector1, Vector2D vector2)
        {
            return ((vector1.X < vector2.X), (vector1.Y < vector2.Y));
        }
        public static List<Vector2D> operator +(List<Vector2D> vectors,Vector2D vector)
        {
            for (int i = 0; i < vectors.Count; i++)
            {
                vectors[i] = vectors[i] + vector;
            }
            return vectors;
        }
    }
}
