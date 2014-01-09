using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmallWorld
{
    public class Map : SmallWorld.I_Map
    {
        private Hashtable unitOnSlotP1;
        private Hashtable unitOnSlotP2;

        public MapFactory MapFactory;

        public Map(int nbSlot)
        {
            unitOnSlotP1 = new Hashtable();
            unitOnSlotP2 = new Hashtable();
            unitOnSlot[0] = //TODO
        }

        public void countPoints()
        {
            throw new System.NotImplementedException();
        }

        public void movmentUnit()
        {
            throw new System.NotImplementedException();
        }

        public void possibleFight()
        {
            throw new System.NotImplementedException();
        }

        public void possibleMovment()
        {
            throw new System.NotImplementedException();
        }

        public void selectUnit()
        {
            throw new System.NotImplementedException();
        }

        public void selectUnitSlot()
        {
            throw new System.NotImplementedException();
        }

        public void slotTaken()
        {
            throw new System.NotImplementedException();
        }
    }
}
