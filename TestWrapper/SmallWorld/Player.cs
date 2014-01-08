using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmallWorld
{
    public class Player : I_Player
    {
        private int points;
        private int totalUnit;

        public Player(string civ, int tUnit)
        {
            //Civilization = civ;
            totalUnit = tUnit;
        }

        public Civilization Civilization
        {
            get;
            set;
        }

        public Unit Unit
        {
            get;
            set;
        }

        public void resetMovmentPoints()
        {
            throw new System.NotImplementedException();
        }
    }
}
