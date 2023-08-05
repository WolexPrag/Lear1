using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lear1
{
    public interface IDisplay
    {
        public void Display();
    }

    interface ICheakCollison
    {
        public bool CheakCollision(Vector2D other);
    }
}
