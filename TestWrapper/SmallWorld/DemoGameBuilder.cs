using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmallWorld
{
    public class DemoGameBuilder : MapFactory, I_DemoGameBuilder
    {
        public Map map;
        public MapFactory mapFactory;

        public DemoGameBuilder() {
            map = null;
            mapFactory = new MapFactory();
        }

        public void setMap(List<int> intMap)
        {
            map = new Map(25);
            int i;
            for (i = 0; i < 25; i++)
            {
                map.matSlot[i] = mapFactory.getSlot(intMap[i]);
            }
        }

        public Map getMap()
        {
            return map;
        }
    }
}
