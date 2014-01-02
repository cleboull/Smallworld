using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmallWorld
{
    public class Game : I_Game, SmallWorld.I_Game
    {
        private bool unitSelected;
        private int nbUnitOnSlot;
        private bool slotTaken;
        private int possibleMovment;
        private int possibleFight;
        private int currentPlayer;
        private int currentRoundNumber;
    
        public Player Player
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public Map Map
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public Map Map1
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public void selectUnit()
        {
            throw new System.NotImplementedException();
        }

        public void deselectUnit()
        {
            throw new System.NotImplementedException();
        }

        public void changePlayer()
        {
            throw new System.NotImplementedException();
        }

        public void nextRound()
        {
            throw new System.NotImplementedException();
        }

        public void setCurrentPlayer(int player)
        {
            throw new System.NotImplementedException();
        }

        public void createGame()
        {
            throw new System.NotImplementedException();
        }

        public Player getFirstPlayer()
        {
            throw new System.NotImplementedException();
        }

        public void endGame()
        {
            throw new System.NotImplementedException();
        }
    }
}
