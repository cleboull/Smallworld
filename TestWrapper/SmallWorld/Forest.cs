using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmallWorld
{
    public class Forest : Slot, I_Forest
    {
        public override string getType()
        {
            return "Forest";
        }
    }
}
