using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmallWorld
{
    public class Player : I_Player
    {
        private int points = new int();
        private Civilization playerCiv;
        private int totalUnit = new int();
        private List<Unit> unitList = new List<Unit>();

        public Player(string civ, int tUnit)
        {
            points = new int();
            points = 0;
            switch (civ)
            {
                case "Vikings":
                    playerCiv = new VikingFactory();
                    break;
                case "Gaulois":
                    playerCiv = new GallicFactory();
                    break;
                case "Nains":
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

        public List<Unit> getUnitList()
        {
            return unitList;
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
