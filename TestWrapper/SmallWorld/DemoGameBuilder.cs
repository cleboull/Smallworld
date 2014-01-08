using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmallWorld
{
    public class DemoGameBuilder : MapFactory, I_DemoGameBuilder
    {
        public Map map;

        public DemoGameBuilder() {
            map = null;
        }

        public void setMap(List<int> intMap)
        {
            map = new Map(5);
            
        }

        public Map getMap()
        {
            return map;
        }
    }
}
