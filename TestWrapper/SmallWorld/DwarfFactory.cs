using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmallWorld
{
    public class DwarfFactory : Civilization, I_DwarfFactory
    {
        public void createUnit()
        {
            throw new System.NotImplementedException();
        }
    }

    public class CopyOfDwarfFactory : I_DwarfFactory
    {
    }
}
