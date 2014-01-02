using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmallWorld
{
    public interface I_StandardGameBuilder : I_MapFactory
    {
        void setMap();
    }
}
