using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmallWorld
{
    public class DwarfUnit : Unit, I_DwarfUnit, SmallWorld.I_DwarfUnit
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
