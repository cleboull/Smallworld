using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmallWorld
{
    public interface I_Game
    {
        I_Player I_Player
        {
            get;
            set;
        }

        I_Map I_Map
        {
            get;
            set;
        }
    }
}
