using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lear1
{
    public struct Byrd : IGetPosition,IPrint
    {
        public int X { set; get; }
        public int Y { set; get; }
        public int HeightJump;
        public int HeightFall;
        public ConsoleColor byrdColor;
        public Byrd(int X,int Y,ConsoleColor byrdColor = ConsoleColor.Magenta, int HeightJump = 3, int HeightFall = 1)
        {
            this.X = X;
            this.Y = Y;
            this.HeightJump = HeightJump;
            this.HeightFall = HeightFall;
            this.byrdColor = byrdColor;
        }
        public void Jump()
        {
            Y = Y - HeightJump;
        }
        public void Fall() 
        { 
            Y = Y + HeightFall; 
        }
        public void Draw()
        {
            new Pixel(X, Y, byrdColor).Draw();
        }
        public void Clear()
        {
            new Pixel(X, Y, byrdColor).Clear();
        }
        public (int, int) GetPosition()
        {
            return (X,Y);
        }
    }
}
