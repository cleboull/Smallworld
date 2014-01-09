using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmallWorld
{
    public class Game : I_Game
    {
        private Unit unitSelected;
        private bool isUnitSelected;
        private int nbUnitOnSlot;
        private bool slotTaken;
        private bool possibleMovment;
        private bool possibleFight;
        private int currentPlayer;
        private int currentRoundNumber;
        private int roundNumberMax;
        private int firstPlayer;
        public Player player1;
        public Player player2;
        public Map map;

        public Game(string civP1Name, string civP2Name, int totalUnit, int firstP, Map mapConst, int roundMax)
        {
            player1 = new Player(civP1Name, totalUnit);
            player2 = new Player(civP2Name, totalUnit);
            firstPlayer = firstP;
            currentPlayer = firstP;
            currentRoundNumber = 1;
            roundNumberMax = roundMax;
            unitSelected = null;
            isUnitSelected = false;
            nbUnitOnSlot = 0;
            possibleFight = false;
            possibleMovment = false;
            map = mapConst;
        }

        public void selectSlot(Slot slot)
        {
            map.selectSlot(slot);
        }

        public void selectUnit(Unit unit)
        {
            map.
            isUnitSelected = true;
            unitSelected = unit;
        }

        public void deselectUnit()
        {
            unitSelected = null;
            isUnitSelected = false;
        }

        public void changePlayer()
        {
            currentPlayer = (currentPlayer % 2) + 1;
        }

        public void countPoints()
        {

        }

        public void nextRound()
        {
            changePlayer();
            currentRoundNumber++;
            if (currentRoundNumber == roundNumberMax)
                gameOver();
        }

        public void setCurrentPlayer(int player)
        {
           currentPlayer = player;
        }

        public Player getFirstPlayer()
        {
            if (firstPlayer == 1)
                return player1;
            else
                return player2;
        }

        public string gameOver()
        {
            if(player1.getPoints() > player2.getPoints())
                return "player1";
            else if(player1.getPoints() < player2.getPoints())
                return "player2";
            else
                return "draw";
        }
    }
}
