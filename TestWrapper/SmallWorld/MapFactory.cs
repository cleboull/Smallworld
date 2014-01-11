using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmallWorld
{
    public class MapFactory : I_MapFactory
    {
        Mountain mountain;
        Plain plain;
        Desert desert;
        Sea sea;
        Forest forest;

        public void buildMap()
        {
            mountain = new Mountain();
            plain = new Plain();
            desert = new Desert();
            sea = new Sea();
            forest = new Forest();
        }

        public Slot getSlot(int slotType){
            switch (slotType)
            {
                case 0: return desert;
                case 1: return forest;
                case 2: return mountain;
                case 3: return plain;
                case 4: return sea;
                default: throw new Exception("Problème lors de la génération aléatoire de la carte");
            }
        }
    }
}
