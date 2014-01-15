using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmallWorld
{
    public class SmallGameBuilder : MapFactory, I_SmallGameBuilder
    {
        public Map map;
        public MapFactory mapFactory;

        public SmallGameBuilder() {
            map = null;
            mapFactory = new MapFactory();
        }

        public void setMap(List<int> intMap)
        {
            map = new Map(100);
            mapFactory = new MapFactory();
            int i;
            for (i = 0; i < 100; i++)
            {
                map.setSlot(i, mapFactory.getSlot(intMap[i]));
            }
        }

        public Map getMap()
        {
            return map;
        }
    }
}
