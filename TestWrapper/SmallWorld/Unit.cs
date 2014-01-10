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

        public Unit()
        {
            movementPoints = 1;
            powerPoints = 2;
            defensePoints = 1;
            health = 5;
        }
    }
}
