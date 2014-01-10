using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmallWorld
{
    public class GallicFactory : Civilization, I_GallicFactory
    {
        public override Unit createUnit()
        {
            return new GallicUnit();
        }
    }
}
