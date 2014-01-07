﻿using System;
namespace SmallWorld
{
    interface I_Slot
    {
        void addUnit();
        int countPointsSlot(Civilization civ);
        void removeUnit(Unit unitSelected);
        System.Collections.Generic.List<Unit> selectUnitList();
        bool slotTaken();
        Unit strongestUnit();
    }
}