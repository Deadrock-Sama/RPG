namespace Core.PlayerNS.InventoryNS.Equipment.Weapons
{
    public interface IWeapon : IEquipment
    {

        bool IsStartItem { get; set; }
    }
}
