﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmallWorld
{
    public interface I_Civilization
    {
        I_Unit_Factory getFactory();

        void setFactory();
    }
}