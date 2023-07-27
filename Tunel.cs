using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lear1
{
    struct Tunel : IGetPosition,IPrint
    {
        public int X;
        public int Y;
        public int Weight;
        public int HeightSpace;
        public ConsoleColor Color;
        public int MapHeight;
        public Tunel(int X,int Y, int MapHeight,int Weight = 1,int HeightSpace = 11,ConsoleColor Color = ConsoleColor.Green)
        {
            this.X = X;
            this.Y = Y;
            this.Weight = Weight;
            this.HeightSpace = HeightSpace;
            this.Color = Color;
            this.MapHeight = MapHeight;
        }

        public void Clear()
        {
            for (int y = 1; y < MapHeight-1; y++)
            {
                if (!(y > Y && y < Y + HeightSpace))
                {
                    new Pixel(x: X, y: y).Clear();
                }
                
            }
            
        }
        public void Draw()
        {
            for (int y = 1; y < MapHeight - 1; y++)
            {
                if (!(y > Y && y < Y + HeightSpace))
                {
                    new Pixel(x: X, y: y, color: Color).Draw();
                }
                
            }
            
        }

        public (int, int) GetPosition()
        {
            return (X, Y);
        }
        
    }
}
