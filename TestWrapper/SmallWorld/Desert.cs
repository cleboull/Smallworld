﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmallWorld
{
    public class Desert : Slot, I_Desert
    {
        public override string getType()
        {
            return "Desert";
        }
    }
}
