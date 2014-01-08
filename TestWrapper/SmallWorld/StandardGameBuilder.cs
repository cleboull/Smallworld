using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmallWorld
{
    public class StandardGameBuilder : MapFactory, I_StandardGameBuilder
    {
        public Map map;

        public StandardGameBuilder() {
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
