using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmallWorld
{
    public class VikingUnit : Unit, I_VikingUnit, SmallWorld.I_VikingUnit
    {
        public void reduceMovementPoints(Slot typeSlot)
        {
            throw new System.NotImplementedException();
        }

        public int getWinPoints(Slot typeSlot)
        {
            throw new System.NotImplementedException();
        }
    }
}
