using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmallWorld
{
    public class Map : SmallWorld.I_Map
    {
        private Slot[] matSlot;
        private MapFactory MapFactory;

        public Map(int nbSlot)
        {
            matSlot = new Slot[nbSlot];
        }

        public void setSlot(int i, Slot slot)
        {
            matSlot[i] = slot;
        }

        public Slot getSlot(int i)
        {
            return matSlot[i];
        }
    }
}
