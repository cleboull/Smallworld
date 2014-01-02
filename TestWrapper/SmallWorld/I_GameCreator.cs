using System;
namespace SmallWorld
{
    interface I_GameCreator
    {
        DemoGameBuilder DemoGameBuilder { get; set; }
        Game Game { get; set; }
        void randomFirstPlayer();
        SmallGameBuilder SmallGameBuilder { get; set; }
        StandardGameBuilder StandardGameBuilder { get; set; }
        void unitPlacement();
    }
}
