using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmallWorld
{
    public class MapFactory : I_MapFactory
    {
        public Mountain mountain;
        public Plain plain;
        public Desert desert;
        public Sea sea;
        public Forest forest;

        public void buildMap()
        {
            mountain = new Mountain();
            plain = new Plain();
            desert = new Desert();
            sea = new Sea();
            forest = new Forest();
        }

        public Slot getSlot(int slotNumber){
            switch (slotNumber)
            {
                case 1: return desert;
                case 2: return forest;
                case 3: return mountain;
                case 4: return plain;
                case 5: return sea;
                default: throw new Exception("Problème lors de la génération aléatoire de la carte");
            }
        }
    }
}
