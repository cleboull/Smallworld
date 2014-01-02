using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmallWorld
{
    public class GameCreator : I_GameCreator, SmallWorld.I_GameCreator
    {
        private @enum mapSize;
        private @enum civP1;
        private int civP2;
        private int roundNumberMax;
        private int firstPlayer;
    
        public Game Game
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public DemoGameBuilder DemoGameBuilder
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public SmallGameBuilder SmallGameBuilder
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public StandardGameBuilder StandardGameBuilder
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public void unitPlacement()
        {
            throw new System.NotImplementedException();
        }

        public void randomFirstPlayer()
        {
            throw new System.NotImplementedException();
        }
    }
}
