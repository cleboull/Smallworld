using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmallWorld
{
    public interface I_Player
    {
        I_Civilization I_Civilization
        {
            get;
            set;
        }

        I_Unit I_Unit
        {
            get;
            set;
        }
    }
}
