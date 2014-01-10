using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using mWrapper;

namespace SmallWorld
{
    public class Game : I_Game
    {
        Unit unitSelected;
        bool isUnitSelected;
        int nbUnitOnSlot;
        bool slotTaken;
        bool possibleMovment;
        bool possibleFight;
        int currentPlayer;
        int currentRoundNumber;
        int roundNumberMax;
        int firstPlayer;
        List<Unit>[] placementUnitP1;
        List<Unit>[] placementUnitP2;
        List<int> intMap;

        Player player1;
        Player player2;
        Map map;

        public Game(string civP1Name, string civP2Name, int totalUnit, int firstP, Map mapConst, List<int> iMap, int roundMax)
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
            intMap = iMap;
            map = mapConst;

            positionUnits();
        }

        public void positionUnits()
        {
            WrapperMap wm = new WrapperMap();
            //int[] positionUnit = wm.GetPositionUnit(intMap);

            placementUnitP1[/*positionUnit[0]*/0] = player1.getUnitList();
            placementUnitP2[/*positionUnit[1]*/1] = player2.getUnitList();
        }

        public List<int> getMap()
        {
            return intMap;
        }

        public void selectSlot(Slot slot)
        {
            
        }

        public void selectUnit(Unit unit)
        {
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
