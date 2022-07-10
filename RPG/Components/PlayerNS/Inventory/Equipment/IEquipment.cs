using RPG.Components.PlayerNS.Characteristics;

namespace RPG.Components.PlayerNS.Inventory.Equipment
{
    public interface IEquipment : IInventoryItem
    {

        
        bool isAbleToWear();

    }
}
