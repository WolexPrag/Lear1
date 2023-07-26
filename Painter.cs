using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lear1
{
    public interface IPrint
    {
        public void Draw() { new Pixel().Draw(); }
        public void Clear() { new Pixel().Clear(); }
    }
}
