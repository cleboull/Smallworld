using System;
namespace SmallWorld
{
    interface I_VikingUnit : I_Unit
    {
        int getWinPoints(Slot typeSlot);
        void reduceMovementPoints(Slot typeSlot);
    }
}
