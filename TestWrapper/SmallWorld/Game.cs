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
        bool isUnitSelected = new bool();
        int nbUnitOnSlot = new int();
        bool slotTaken = new bool();
        bool possibleMovment = new bool();
        bool possibleFight = new bool();
        int currentPlayer = new int();
        int currentRoundNumber = new int();
        int roundNumberMax = new int();
        int firstPlayer = new int();
        List<Unit>[] placementUnitP1;
        List<Unit>[] placementUnitP2;
        int pointsP1 = new int();
        int pointsP2 = new int();
        List<int> intMap = new List<int>();

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
            pointsP1 = 0;
            pointsP2 = 0;
            nbUnitOnSlot = 0;
            possibleFight = false;
            possibleMovment = false;
            intMap = iMap;

            int taille=iMap.Count;
            map = new Map(taille);
            map = mapConst;
            
            placementUnitP1 = new List<Unit>[taille];
            placementUnitP2 = new List<Unit>[taille];
            positionUnits();
        }

        public void positionUnits()
        {
            WrapperMap wm = new WrapperMap();
            
            int[] positionUnit = wm.GetPositionUnit(intMap);

            placementUnitP1[positionUnit[0]] = player1.getUnitList();
            placementUnitP2[positionUnit[1]] = player2.getUnitList();
        }

        public List<int> getMap()
        {
            return intMap;
        }

        public bool selectSlot(int intSlot)
        {
            if(currentPlayer == 1)
            {
                int nbUnit = placementUnitP1[intSlot].Count;
                if (nbUnit > 0)
                    return true;
                return false;
            }
            else if (currentPlayer == 2)
            {
                int nbUnit = placementUnitP2[intSlot].Count;
                if (nbUnit > 0)
                    return true;
                return false;
            }
            else
                throw new Exception("Erreur Joueur courant");
        }

        public List<Unit> selectUnit(int intSlot)
        {
            if (currentPlayer == 1)
                return placementUnitP1[intSlot];
            else if (currentPlayer == 2)
                return placementUnitP2[intSlot];
            else
                throw new Exception("Erreur Joueur courant");
        }

        public void possibleDeplacement(Unit unit, Slot slotDest)
        {

        }

        public void deplaceUnit(Unit unit)
        {
            
        }

        public void deselectUnit()
        {
            unitSelected = null;
        }

        public void changePlayer()
        {
            currentPlayer = (currentPlayer % 2) + 1;
        }

        public void countPoints()
        {
            //Joueur 1

            
        }

        public void nextRound()
        {
            changePlayer();
            currentRoundNumber++;
            if (currentRoundNumber == roundNumberMax)
                gameOver();
        }

        public int getP1Points()
        {
            return pointsP1;
        }

        public int getP2Points()
        {
            return pointsP2;
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
