using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmallWorld
{
    public abstract class Unit : SmallWorld.I_Unit
    {
        private int movementPoints = new int();
        private int powerPoints = new int();
        private int defensePoints = new int();
        private int health = new int();

        public Unit()
        {
            movementPoints = 1;
            powerPoints = 2;
            defensePoints = 1;
            health = 5;
        }



        public int getPDV()
        {
            return health;
        }

        public void setPDV(int pdv)
        {
            health = pdv;
        }

        public int getDEF()
        {
            return defensePoints;
        }

        public int getATK()
        {
            return powerPoints;
        }

        public int getMOV()
        {
            return movementPoints;
        }

        public void setMOV(int mov)
        {
            movementPoints = mov;
        }
    }
}
