using System;
namespace SmallWorld
{
    interface I_Player
    {
        Civilization Civilization { get; set; }
        void resetMovmentPoints();
        Unit Unit { get; set; }
        Unit Unit1 { get; set; }
    }
}
