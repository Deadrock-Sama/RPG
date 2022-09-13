using Core.PlayerNS.Sets;

namespace Core.PlayerNS.InventoryNS.Equipment
{
    public interface IEquipment : IInventoryItem, IEquipmentStatsController
    {

        bool isAbleToWear();

    }
}
