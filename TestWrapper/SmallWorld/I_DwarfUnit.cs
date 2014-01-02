using System;
namespace SmallWorld
{
    interface I_DwarfUnit : I_Unit
    {
        int getWinPoints(Slot typeSlot);
        void reduceMovementPoints(Slot typeSlot);
    }
}
