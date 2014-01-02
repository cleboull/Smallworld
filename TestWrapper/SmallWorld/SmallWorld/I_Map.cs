using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmallWorld
{
    public interface I_Map
    {
        I_Slot I_Slot
        {
            get;
            set;
        }

        I_MapFactory I_MapFactory
        {
            get;
            set;
        }
    }
}
