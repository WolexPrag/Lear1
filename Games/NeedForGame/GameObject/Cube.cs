using Learn1.Game;

namespace Learn1.Game
{
    public class Cube : IDisplay, ICheakCollison
    {
        protected Vector2D _position; public Vector2D position
        {
            get { return _position; }
            set { _position = value; }
        }
        protected Vector2D _minPos; public Vector2D minPos
        {
            get { return _minPos + position; }
            set
            {
                if (minPos == null)
                {
                    _maxPos = value;
                }
                else if (value.X > maxPos.X || value.Y > maxPos.Y)
                {
                    _minPos = maxPos;
                }
                else
                {
                    _minPos = value;
                }
            }
        }
        protected Vector2D _maxPos; public Vector2D maxPos
        {
            get { return _maxPos + position; }
            set
            {
                if (minPos == null)
                {
                    _maxPos = value;
                }
                else if (value.X < minPos.X || value.Y < minPos.Y)
                {
                    _maxPos = _minPos;
                }
                else
                {
                    _maxPos = value;
                }
            }
        }
        public Cube()
        {
            this.position = new Vector2D();
            this.minPos = new Vector2D();
            this.maxPos = new Vector2D();
        }
        public Cube(Vector2D minPos, Vector2D maxPos, Vector2D position)
        {
            this.position = position;
            this.minPos = minPos;
            this.maxPos = maxPos;
        }
        public Cube(Vector2D minPos, Vector2D maxPos)
        {
            this.position = new Vector2D();
            this.minPos = minPos;
            this.maxPos = maxPos;
        }
        public bool IsFull(Vector2D pos)
        {
            if (minPos.X > pos.X && pos.X < maxPos.X)
            {
                if (minPos.Y > pos.Y && pos.Y < maxPos.Y)
                {
                    return true;
                }
            }
            return false;
        }
        public void Display()
        {
            for (int x = minPos.X; x < maxPos.X; x++)
            {
                for (int y = minPos.Y; y < maxPos.Y; y++)
                {
                    new Pixel(new Vector2D(x, y)).Display();
                }
            }
        }
        public void Clear()
        {
            for (int x = 0; x < maxPos.X; x++)
            {
                for (int y = 0; y < maxPos.Y; y++)
                {
                    new Pixel(new Vector2D(x, y)).Clear();
                }
            }
        }
        public bool CheakCollision(Vector2D other)
        {
            return IsFull(other);
        }
    }
}
