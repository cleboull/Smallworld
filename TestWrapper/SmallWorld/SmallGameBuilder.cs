using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmallWorld
{
    public class SmallGameBuilder : MapFactory, I_SmallGameBuilder
    {
        public Map map;

        public SmallGameBuilder() {
            map = null;
        }

        public void setMap(List<int> intMap)
        {

        }

        public Map getMap()
        {
            return map;
        }
    }
}
