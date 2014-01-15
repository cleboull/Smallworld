using mWrapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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
        int sizeMap = new int();
        List<Unit>[] placementUnitP1;
        List<Unit>[] placementUnitP2;
        int pointsP1 = new int();
        int pointsP2 = new int();
        List<int> intMap = new List<int>();

        Player player1;
        Player player2;
        Map map;

        public Game() { }

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

            sizeMap=iMap.Count;
            map = new Map(sizeMap);
            map = mapConst;
            
            placementUnitP1 = new List<Unit>[sizeMap];
            placementUnitP2 = new List<Unit>[sizeMap];
            positionUnits();
        }

        public void positionUnits()
        {
            WrapperMap wm = new WrapperMap();

            List<int> positionUnit = new List<int>();
            //positionUnit = wm.GetPositionInit(intMap);
            int i;
            for(i=0;i<sizeMap;i++) {
                if (i == 0)
                {
                    placementUnitP1[0] = new List<Unit>();
                    placementUnitP1[i] = player1.getUnitList();
                }
                else
                    placementUnitP1[i] = new List<Unit>();
            }

            for (i = 0; i < sizeMap; i++)
            {
                if(i == sizeMap-1){

                    placementUnitP2[i] = new List<Unit>();
                    placementUnitP2[i] = player2.getUnitList();
                }
                else
                    placementUnitP2[i] = new List<Unit>();
            }
            
        }

        public String getCiv(String player)
        {
            if (player == "J1")
                return player1.getCiv();
            else if (player == "J2")
                return player2.getCiv();
            else
                throw new Exception("Joueur non reconnu");

        }

        public List<int> getMap()
        {
            return intMap;
        }

        public int getRound()
        {
            return currentRoundNumber;
        }

        public int getRoundMax()
        {
            return roundNumberMax;
        }

        public int getCurrentPlayer()
        {
            return currentPlayer;
        }

        public bool selectSlot(int x, int y)
        {
            int intSlot = x + (y * (int)Math.Sqrt(sizeMap));
            if(currentPlayer == 1)
            {
                if (placementUnitP1[intSlot]!=null)
                    return true;
                return false;
            }
            else if (currentPlayer == 2)
            {
                if (placementUnitP2[intSlot] != null)
                    return true;
                return false;
            }
            else
                throw new Exception("Erreur Joueur courant");
        }

        public List<Unit> selectUnit(int x, int y)
        {
            int intSlot = x + (y * (int)Math.Sqrt(sizeMap));
            if (currentPlayer == 1)
                return placementUnitP1[intSlot];
            else if (currentPlayer == 2)
                return placementUnitP2[intSlot];
            else
                throw new Exception("Erreur Joueur courant");
        }

        public int[] getUnitPos(String player)
        {  
            int[] unitPos = new int [sizeMap+1];
            int i = 0, j = 0;
            int nbUnit = 0;
            if (player == "J1") {
                for (i = 0; i < sizeMap; i++)
                {
                    if (placementUnitP1[i] != null)
                    {
                        nbUnit = placementUnitP1[i].Count;
                        while (nbUnit != 0)
                        {
                            unitPos[j] = i;
                            nbUnit--;
                            j++;
                        }
                    }
                }
            }
            else {
                for (i = 0; i < sizeMap; i++)
                {
                    if (placementUnitP2[i] != null)
                    {
                        nbUnit = placementUnitP2[i].Count;
                        while (nbUnit != 0)
                        {
                            unitPos[j] = i;
                            nbUnit--;
                            j++;
                        }
                    }
                }
            }
            return unitPos;
        }

        public int getNbUnit()
        {
            int nbUnit=0;
            foreach (List<Unit> ListUnit in placementUnitP1)
                if (ListUnit != null)
                    nbUnit += ListUnit.Count;
            return nbUnit;
        }

        public bool moveUnit(Unit unit, int x1, int y1)
        {
            int intSlotOrigin = 0;
            int x0, y0;
            int size = (int)Math.Sqrt(sizeMap);
            int intSlotDest = x1 + (y1 * size);
            if (unit.getMOV() == 1)
            {
                if (currentPlayer == 1)
                {
                    while (!placementUnitP1[intSlotOrigin].Contains(unit))
                        intSlotOrigin++;
                    x0 = intSlotOrigin % size;
                    y0 = intSlotOrigin / size;
                    if ((x0 == x1 || y1 == y0) &&
                        ((Math.Abs(x0 - x1) == 1 && !(((x0 % size) == 0 && (x1 + 1) % size == 0) || ((x1 % size) == 0 && (x0 + 1) % size == 0)))
                        || ((Math.Abs(y0 - y1) == 1 && !(((y0 % size) == 0 && (y1 + 1) % size == 0) || ((y1 % size) == 0 && (y0 + 1) % size == 0))))))
                    //La case sélectionnée est une case adjacente
                    {
                        if (placementUnitP2[intSlotDest].Count != 0)
                            combat(intSlotOrigin, intSlotDest);
                        if (placementUnitP2[intSlotDest].Count != 0)//on regarde s'il reste des unités ennemies sur la case destination
                        {
                            if (player1.getCiv() == "Vikings" && intMap[intSlotDest] == 4)
                                return false;
                            else
                            {
                                placementUnitP1[intSlotOrigin].Remove(unit);
                                placementUnitP1[intSlotDest].Add(unit);
                                unit.setMOV(0);
                                return true;
                            }
                        }
                        else
                        {
                            unit.setMOV(0);
                            return false;
                        }
                    }
                }
                else if (currentPlayer == 2)
                {
                    while (!placementUnitP2[intSlotOrigin].Contains(unit))
                        intSlotOrigin++;
                    x0 = intSlotOrigin % size;
                    y0 = intSlotOrigin / size;
                    if ((x0 == x1 || y1 == y0) &&
                        ((Math.Abs(x0 - x1) == 1 && !(((x0 % size) == 0 && (x1 + 1) % size == 0) || ((x1 % size) == 0 && (x0 + 1) % size == 0)))
                        || ((Math.Abs(y0 - y1) == 1 && !(((y0 % size) == 0 && (y1 + 1) % size == 0) || ((y1 % size) == 0 && (y0 + 1) % size == 0))))))
                    //La case sélectionnée est une case adjacente
                    {
                        if (placementUnitP1[intSlotDest].Count != 0)
                            combat(intSlotOrigin, intSlotDest);
                        if (placementUnitP1[intSlotDest].Count != 0)//on regarde s'il reste des unités ennemies sur la case destination
                        {
                            if (player2.getCiv() == "Vikings" && intMap[intSlotDest] == 4)
                                return false;
                            else
                            {
                                placementUnitP2[intSlotOrigin].Remove(unit);
                                placementUnitP2[intSlotDest].Add(unit);
                                unit.setMOV(0);
                                return true;
                            }
                        }
                        else
                        {
                            unit.setMOV(0);
                            return false;
                        }
                    }
                }
            }
            return false;
        }

        public void combat(int intSlotAtk, int intSlotDef)
        {

        }

        public void resetMovPoints()
        {
            foreach (List<Unit> unitList in placementUnitP1)
            {
                foreach (Unit unit in unitList)
                    unit.setMOV(1);
            }
            foreach (List<Unit> unitList in placementUnitP2)
            {
                foreach (Unit unit in unitList)
                    unit.setMOV(1);
            }
        }

        public void deselectUnit()
        {
            unitSelected = null;
            isUnitSelected = false;
        }

        public void changePlayer()
        {
            currentPlayer = (currentPlayer % 2) + 1;
            if (currentPlayer == firstPlayer)
            {
                currentRoundNumber++;
                countPoints();
            }
        }

        public void countPoints()
        {
            int size = (int)Math.Sqrt(sizeMap);
            int i = 0;
            foreach (List<Unit> unitList in placementUnitP1)
            {
                
                if (unitList.Count != 0)
                {
                    if (player1.getCiv() == "Gaulois")
                    {
                        if (intMap[i] == 3)//3 Correspond à une plaine
                            pointsP1 += unitList.Count * 2;
                        else if (intMap[i] != 2)//2 Correspond à montagne
                            pointsP1 += unitList.Count;
                    }
                    if (player1.getCiv() == "Vikings")
                    {
                        if(((i-size >= 0 && intMap[i-size] == 4)
                            || (i+size < sizeMap && intMap[i+size] == 4)
                            || (i%size != 0 && i!=sizeMap && intMap[i-1] == 4)
                            || ( (i+1)% size != 0 && i!=0 && intMap[i+1] == 4)) && (intMap[i] != 0 && intMap[i] != 4))
                            pointsP1 += unitList.Count * 2;

                        else if(intMap[i] != 0 && intMap[i] != 4)//Desert ou Eau
                            pointsP1 += unitList.Count;
                    }
                    if (player1.getCiv() == "Nains")
                    {
                        if (intMap[i] == 1)//1 Correspond à Foret
                            pointsP1 += unitList.Count * 2;
                        else if (intMap[i] != 3)//3 Correspond à Plaine
                            pointsP1 += unitList.Count;
                    }
                }
                i++;
            }
            i = 0;
            foreach (List<Unit> unitList in placementUnitP2)
            {
                if (unitList.Count != 0)
                {
                    if (player2.getCiv() == "Gaulois")
                    {
                        if (intMap[i] == 3)//3 Correspond à une plaine
                            pointsP2 += unitList.Count * 2;
                        else if (intMap[i] != 2)//2 Correspond à montagne
                            pointsP2 += unitList.Count;
                    }
                    if (player2.getCiv() == "Vikings")
                    {
                        if (((i - size >= 0 && intMap[i - size] == 4)
                            || (i + size < sizeMap && intMap[i + size] == 4)
                            || (i % size != 0 && i != sizeMap && intMap[i - 1] == 4)
                            || ((i + 1) % size != 0 && i != 0 && intMap[i + 1] == 4)) && (intMap[i] != 0 && intMap[i] != 4))
                            pointsP2 += unitList.Count * 2;

                        else if (intMap[i] != 0 && intMap[i] != 4)//Desert ou Eau
                            pointsP2 += unitList.Count;
                    }
                    if (player2.getCiv() == "Nains")
                    {
                        if (intMap[i] == 1)//1 Correspond à Foret
                            pointsP2 += unitList.Count * 2;
                        else if (intMap[i] != 3)//3 Correspond à Plaine
                            pointsP2 += unitList.Count;
                    }
                }
                i++;
            }
        }

        public bool isGameOver()
        {
            return (currentRoundNumber > roundNumberMax);
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

        public string getWinner()
        {
            if (pointsP1 > pointsP2)
                return "Joueur 1";
            else if (pointsP1 < pointsP2)
                return "Joueur 2";
            else
                return "draw";
        }
    }
}
