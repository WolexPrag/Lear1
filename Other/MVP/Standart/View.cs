using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn1.Other.MVP.Standart
{
    public abstract class View
    {
        public Presenter _presenter;
        public void Init(Presenter presenter)
        {
            _presenter = presenter;
        }
        public abstract string GetName();
    }
}
