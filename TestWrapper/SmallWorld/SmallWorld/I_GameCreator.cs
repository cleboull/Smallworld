using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmallWorld
{
    public interface I_GameCreator
    {
        I_Game I_Game
        {
            get;
            set;
        }

        I_DemoGameBuilder I_DemoGameBuilder
        {
            get;
            set;
        }

        I_SmallGameBuilder I_SmallGameBuilder
        {
            get;
            set;
        }

        I_StandardGameBuilder I_StandardGameBuilder
        {
            get;
            set;
        }
    
        void createGame();

        void setMap();
    }
}
