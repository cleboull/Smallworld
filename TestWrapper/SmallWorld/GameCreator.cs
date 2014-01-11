using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using mWrapper;

namespace SmallWorld
{
    public class GameCreator : I_GameCreator
    {
        private Game game;

        public GameCreator(string civ1, string civ2, string mapSize)
        {
            WrapperMap wm = new WrapperMap();
            List<int> intMap = new List<int>();
            int roundNumberMax = new int();
            int totalUnit = new int();
            Map map;
            switch (mapSize)
            {
                case "Demo":
                    roundNumberMax = 5;
                    totalUnit = 4;
                    DemoGameBuilder demoGameBuilder = new DemoGameBuilder();
                    map = new Map(25);
                    intMap = wm.CreateMapWrapper(5);
                    demoGameBuilder.setMap(intMap);
                    map = demoGameBuilder.getMap();
                    break;
                case "Petite":
                    roundNumberMax = 20;
                    totalUnit = 6;
                    SmallGameBuilder smallGameBuilder = new SmallGameBuilder();
                    map = new Map(100);
                    intMap = wm.CreateMapWrapper(10);
                    smallGameBuilder.setMap(intMap);
                    map = smallGameBuilder.getMap();
                    break;
                case "Normale":
                    roundNumberMax = 30;
                    totalUnit = 8;
                    StandardGameBuilder standardGameBuilder = new StandardGameBuilder();
                    map = new Map(225);
                    intMap = wm.CreateMapWrapper(15);
                    standardGameBuilder.setMap(intMap); 
                    map = standardGameBuilder.getMap();
                    break;
                default:
                    throw new Exception("Mauvais type de carte");
            }
            Random rnd = new Random();
            int firstPlayer= rnd.Next(2);
            game = new Game(civ1, civ2, totalUnit, firstPlayer, map, intMap, roundNumberMax);
        }

        public Game getGame()
        {
            return game;
        }
    }
}
