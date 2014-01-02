using System;
namespace SmallWorld
{
    interface I_Map
    {
        void countPoints();
        MapFactory MapFactory { get; set; }
        void movmentUnit();
        void possibleFight();
        void possibleMovment();
        void selectUnit();
        void selectUnitSlot();
        Slot Slot { get; set; }
        void slotTaken();
    }
}
