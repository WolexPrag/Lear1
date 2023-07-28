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
    }

    internal interface ICheakCollison 
    {
        public bool CheakCollision(Vector2D other);
    }
}
