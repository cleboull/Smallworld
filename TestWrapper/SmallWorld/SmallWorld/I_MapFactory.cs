using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmallWorld
{
    public interface I_MapFactory
    {
        Mountain Mountain
        {
            get;
            set;
        }

        Plain Plain
        {
            get;
            set;
        }

        Desert Desert
        {
            get;
            set;
        }

        Sea Sea
        {
            get;
            set;
        }

        int Forest
        {
            get;
            set;
        }
    }
}
