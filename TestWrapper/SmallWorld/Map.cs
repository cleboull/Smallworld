using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmallWorld
{
    public class Map : SmallWorld.I_Map
    {
        public Slot[] matSlot;

        public MapFactory MapFactory;

        public Map(int nbSlot)
        {
            matSlot = new Slot[nbSlot];
        }
    }
}
