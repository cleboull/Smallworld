using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmallWorld
{
    public class GallicUnit : Unit, I_GallicUnit, SmallWorld.I_GallicUnit
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
