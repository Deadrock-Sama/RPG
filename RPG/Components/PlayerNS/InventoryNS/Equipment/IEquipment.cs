using RPG.Components.PlayerNS.Sets;

namespace RPG.Components.PlayerNS.InventoryNS.Equipment
{
    public interface IEquipment : IInventoryItem, IStatsController
    {




        bool isAbleToWear();

    }
}
