using Core.PlayerNS.CharacteristicsNS;

namespace Core.PlayerNS.InventoryNS.Equipment.Weapons
{
    public class Weapon : Equipment, IWeapon
    {
        public virtual StatsBonus Stats { get; set; }

        public virtual bool IsStartItem { get; set; }

        public virtual bool isAbleToWear()
        {
            throw new NotImplementedException();
        }
    }
}
