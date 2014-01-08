using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmallWorld
{
    public class GallicFactory : Civilization, I_GallicFactory
    {
        public Unit createUnit()
        {
            return new GallicUnit();
        }
    }
}
