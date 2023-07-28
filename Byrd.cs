using System;

namespace Lear1
{
    public struct Byrd :  IPrint
    {
        public Vector2D position;
        public int HeightJump;
        public int HeightFall;
        public ConsoleColor byrdColor;
        public Byrd(Vector2D position,ConsoleColor byrdColor = ConsoleColor.Magenta, int HeightJump = 3, int HeightFall = 1)
        {
            this.position = position;
            this.HeightJump = HeightJump;
            this.HeightFall = HeightFall;
            this.byrdColor = byrdColor;
        }
        public void Jump()
        {
            position.Y = position.Y - HeightJump;
        }
        public void Fall() 
        {
            position.Y = position.Y + HeightFall; 
        }
        public void Draw()
        {
            new Pixel(position.X, position.Y, byrdColor).Draw();
        }
        public void Clear()
        {
            new Pixel(position.X, position.Y, byrdColor).Clear();
        }
        
    }
}
