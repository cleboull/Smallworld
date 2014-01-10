using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmallWorld
{
    public abstract class Civilization : I_Civilization
    {
        public abstract Unit createUnit();
    }
}
