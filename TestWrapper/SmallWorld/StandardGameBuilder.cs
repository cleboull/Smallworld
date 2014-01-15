using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmallWorld
{
    public class StandardGameBuilder : MapFactory, I_StandardGameBuilder
    {
        public Map map;
        public MapFactory mapFactory;

        public StandardGameBuilder() {
            map = null;
            mapFactory = new MapFactory();
        }

        public void setMap(List<int> intMap)
        {
            map = new Map(225);
            int i;
            for (i = 0; i < 225; i++)
            {
                map.setSlot(i,mapFactory.getSlot(intMap[i]));
            }
        }

        public Map getMap()
        {
            return map;
        }
    }
}
