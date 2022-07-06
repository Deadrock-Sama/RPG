using RPG.Components.PlayerNS.Characteristics;

namespace RPG.Components.PlayerNS.Inventory.Equipment
{
    public interface IEquipment : IInventoryItem
    {

        IStatsInfo Stats { get; }
        bool isAbleToWear();
        void Wear();
        void TakeOff();
        void Upgrade();
    }
}
