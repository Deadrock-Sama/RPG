using RPG.Components.PlayerComponent.Characteristics;
using System;
using System.Collections.Generic;
using System.Text;

namespace RPG.Components.PlayerComponent.Inventory.Equipment
{
    interface IEquipment : IInventoryItem
    {

        IStatsInfo Stats { get; }
        bool isAbleToWear();
        void Wear();
        void TakeOff();    
        void Upgrade();
    }
}
