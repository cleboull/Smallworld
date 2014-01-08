using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmallWorld
{
    public class Game : I_Game
    {
        private bool unitSelected;
        private int nbUnitOnSlot;
        private bool slotTaken;
        private bool possibleMovment;
        private bool possibleFight;
        private int currentPlayer;
        private int currentRoundNumber;
        public Player player1;
        public Player player2;
        public Map Map;

        public Game(string civP1Name, string civP2Name, int totalUnit, int firstPlayer, Map map, int roundNumberMax)
        {
            player1 = new Player(civP1Name, totalUnit);
            player2 = new Player(civP2Name, totalUnit);
            currentPlayer = firstPlayer;
            currentRoundNumber = 1;
            unitSelected = false;
            nbUnitOnSlot = 0;
            possibleFight = false;
            possibleMovment = false;
        }

        public void selectUnit()
        {
            throw new System.NotImplementedException();
            unitSelected = true;
        }

        public void deselectUnit()
        {
            unitSelected = false;
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
