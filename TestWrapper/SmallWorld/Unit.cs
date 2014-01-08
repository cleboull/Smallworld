using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmallWorld
{
    public abstract class Unit : SmallWorld.I_Unit
    {
        private int movementPoints;
        private int powerPoints;
        private int defensePoints;
        private int health;

        public void setMovPoints(int movPoints)
        {
            throw new System.NotImplementedException();
        }

        public int getMovPoints()
        {
            throw new System.NotImplementedException();
        }

        public void reduceMovementPoints(Slot typeslot)
        {
            throw new System.NotImplementedException();
        }

        public int getSlotPoints()
        {
            throw new System.NotImplementedException();
        }
    }
}
