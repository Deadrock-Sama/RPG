using Core.PlayerNS.CharacteristicsNS;

namespace Core.PlayerNS.InventoryNS.Equipment
{
    public class Equipment : Item, IEquipment
    {
        public virtual StatsBonus Stats { get; set; }

        public virtual bool isAbleToWear()
        {
            throw new NotImplementedException();
        }
    }
}
