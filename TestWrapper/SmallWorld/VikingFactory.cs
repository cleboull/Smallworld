﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmallWorld
{
    public class VikingFactory : Civilization, I_VikingFactory, SmallWorld.I_VikingFactory
    {
        public void createUnit()
        {
            throw new System.NotImplementedException();
        }
    }
}