using Core.PlayerNS.CharacteristicsNS;

namespace Core.PlayerNS.InventoryNS.Equipment.Armor
{

    public class ArmorPart : Equipment, IArmor
    {
        public virtual StatsBonus Stats { get; set; }

        public virtual bool isAbleToWear()
        {
            throw new NotImplementedException();
        }
    }
}
