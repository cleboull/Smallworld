using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmallWorld
{
    public class Player : I_Player
    {
        private int points;
        public Civilization playerCiv;
        private int totalUnit;
        public List<Unit> unitList;

        public Player(string civ, int tUnit)
        {

            points = 0;
            switch (civ)
            {
                case "viking":
                    playerCiv = new VikingFactory();
                    break;
                case "gaulois":
                    playerCiv = new GallicFactory();
                    break;
                case "nain":
                    playerCiv = new DwarfFactory();
                    break;
            }
            totalUnit = tUnit;
            int i;
            for (i = 0; i < totalUnit; i++)
            {
                unitList.Add(playerCiv.createUnit());
            }
        }

        public int getPoints()
        {
            return points;
        }

        public void resetMovmentPoints()
        {
            throw new System.NotImplementedException();
        }
    }
}
