using System;
namespace SmallWorld
{
    interface I_GallicUnit : I_Unit
    {
        int getWinPoints(Slot typeSlot);
        void reduceMovementPoints(Slot typeSlot);
    }
}
