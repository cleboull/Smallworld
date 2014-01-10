using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmallWorld
{
    public class DwarfFactory : Civilization, I_DwarfFactory
    {
        public override Unit createUnit()
        {
            return new DwarfUnit();
        }
    }
}
