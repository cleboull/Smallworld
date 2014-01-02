using System;
namespace SmallWorld
{
    interface I_Game
    {
        void changePlayer();
        void createGame();
        void deselectUnit();
        void endGame();
        Player getFirstPlayer();
        Map Map { get; set; }
        Map Map1 { get; set; }
        void nextRound();
        Player Player { get; set; }
        void selectUnit();
        void setCurrentPlayer(int player);
    }
}
