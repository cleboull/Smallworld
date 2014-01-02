using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmallWorld
{
    public class Map : I_Map
    {
        private Slot[][] matSlotP1;
        private Slot[][] matSlotP2;
    
        public Map()
        {
            throw new System.NotImplementedException();
        }
    
        public MapFactory MapFactory
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public Slot Slot
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public List<Unit> selectUnitSlot(Slot slot)
        {
            throw new System.NotImplementedException();
        }

        public Unit selectUnit()
        {
            throw new System.NotImplementedException();
        }

        public Boolean slotTaken(Slot slot)
        {
            throw new System.NotImplementedException();
        }

        public void possibleMovement(Unit unitSelect, Slot slotDest)
        {
            throw new System.NotImplementedException();
        }

        public void movementUnit(Unit unitSelect, Slot slotDest)
        {
            throw new System.NotImplementedException();
        }
    }
}
