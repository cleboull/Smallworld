using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmallWorld
{
    public class Player : I_Player
    {
        private String civil;
        private Civilization playerCiv;
        private int totalUnit = new int();
        private List<Unit> unitList = new List<Unit>();

        public Player(string civ, int tUnit)
        {
            switch (civ)
            {
                case "Vikings":
                    playerCiv = new VikingFactory();
                    civil = "Vikings";
                    break;
                case "Gaulois":
                    playerCiv = new GallicFactory();
                    civil = "Gaulois";
                    break;
                case "Nains":
                    playerCiv = new DwarfFactory();
                    civil = "Nains";
                    break;
            }
            totalUnit = tUnit;
            int i;
            for (i = 0; i < totalUnit; i++)
            {
                unitList.Add(playerCiv.createUnit());
            }
        }

        public string getCiv()
        {
            return civil;
        }

        public List<Unit> getUnitList()
        {
            return unitList;
        }

        public void resetMovmentPoints()
        {
            throw new System.NotImplementedException();
        }
    }
}
