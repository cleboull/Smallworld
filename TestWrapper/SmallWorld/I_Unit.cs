using System;
namespace SmallWorld
{
    interface I_Unit
    {
        int getMovPoints();
        int getSlotPoints();
        void reduceMovmentPoint(Slot typeslot);
        void setMovPoints(int movPoints);
    }
}
