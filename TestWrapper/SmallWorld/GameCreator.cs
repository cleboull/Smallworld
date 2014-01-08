using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmallWorld
{
    public class GameCreator : I_GameCreator
    {
        public int totalUnit;
        public string mapSize;
        public int roundNumberMax;
        public string civP1Name;
        public string civP2Name;
        public List<int> intMap;
        public Map map;
        public int firstPlayer;
        public DemoGameBuilder demoGameBuilder;
        public SmallGameBuilder smallGameBuilder;
        public StandardGameBuilder standardGameBuilder;
        public Game game;

        public GameCreator(string civ1, string civ2, List<int> iMap, string mapS)
        {
            civP1Name = civ1;
            civP2Name = civ2;
            intMap = iMap;
            mapSize = mapS;
            switch (mapSize)
            {
                case "demo":
                    roundNumberMax = 5;
                    totalUnit = 4;
                    demoGameBuilder = new DemoGameBuilder();
                    demoGameBuilder.setMap(iMap);
                    map = demoGameBuilder.getMap();
                    break;
                case "petite":
                    roundNumberMax = 20;
                    totalUnit = 6;
                    smallGameBuilder = new SmallGameBuilder();
                    smallGameBuilder.setMap(iMap);
                    map = smallGameBuilder.getMap();
                    break;
                case "normale":
                    roundNumberMax = 30;
                    totalUnit = 8;
                    standardGameBuilder = new StandardGameBuilder();
                    standardGameBuilder.setMap(iMap); 
                    map = standardGameBuilder.getMap();
                    break;
                default:
                    throw new Exception("Mauvais type de carte");
            }
        }

        public Game createGame()
        {
            Random rnd = new Random();
            firstPlayer= rnd.Next(2);
            game = new Game(civP1Name, civP2Name, totalUnit, firstPlayer, map, roundNumberMax);
            return game;
        }

        public void unitPlacement()
        {
            throw new System.NotImplementedException();
        }
    }
}
