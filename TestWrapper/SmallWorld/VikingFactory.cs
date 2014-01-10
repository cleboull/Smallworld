using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmallWorld
{
    public class VikingFactory : Civilization, I_VikingFactory
    {
        public override Unit createUnit()
        {
            return new VikingUnit();
        }
    }
}
