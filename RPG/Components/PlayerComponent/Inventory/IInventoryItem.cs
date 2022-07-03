using System;
using System.Collections.Generic;
using System.Text;

namespace RPG.Components.PlayerComponent.Inventory
{
     interface IInventoryItem
    {
        void Craft();
        void Disassemble();
        void ThrowAway();
       
    }
}
