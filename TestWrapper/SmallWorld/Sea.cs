using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmallWorld
{
    public class Sea : Slot, I_Sea
    {
        public override string getType()
        {
            return "Sea";
        }
    }
}
