using Core.PlayerNS.Sets;
using Core.PlayerNS.InventoryNS;

namespace Core.PlayerNS.InventoryNS.Equipment
{
    public interface IEquipment : IInventoryItem, IEquipmentStatsController
    {




        bool isAbleToWear();

    }
}
