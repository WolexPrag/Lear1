using Learn1.Game;

namespace Learn1
{
    public class Byrd : IDisplay, ICheakCollison
    {
        
        protected Vector2D _position; public Vector2D position
        {
            get { return _position; }
            set
            {
                _position = value;
                body.position = value;
            }
        }
        protected Cube body;
        public Byrd()
        {
            this.position = new Vector2D();
        }
        public Byrd(Vector2D position, Cube body)
        {
            this.position = position;
            this.body = body;
        }
        public void Display()
        {
            body.Display();
        }
        public void Clear()
        {
            body.Clear();
        }
        public bool CheakCollision(Vector2D other)
        {
            return body.CheakCollision(other);
        }
        public void Fall(Vector2D gravity)
        {
            position = position + gravity;
        }
        public void Jump(Vector2D gravity)
        {
            position = position + (gravity * -3);
        }
    }
}
