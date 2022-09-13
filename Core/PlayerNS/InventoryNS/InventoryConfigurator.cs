using Core.DBInteraction;
using Core.PlayerNS.InventoryNS.Equipment.Weapons;

namespace Core.PlayerNS.InventoryNS
{
    public class InventoryConfigurator
    {

        private readonly Player _player;
        private readonly Inventory _inventory;
        private readonly IRepositoryShell _repositoryShell;
        //private readonly List<Item> _items = new();
        public InventoryConfigurator(Player player, IRepositoryShell repositoryShell)
        {
            _player = player;
            _inventory = new Inventory(repositoryShell, player);
            _repositoryShell = repositoryShell;
            

        }

        public void SetStartInventory()
        {
            //... опять предпосылка к enum
            switch (_player.PlayerClass.ToString())
            {
                case "Warrior":
                    SetWarriorStartInventory();
                    break;
                case "Wizard":
                    SetWizardStartInventory();
                    break;
                case "Archer":
                    SetArcherStartInventory();
                    break;
            }

        }

        private void SetWarriorStartInventory()
        {
            var weapon = RecieveStartWeapon<Sword>();
            _inventory.AddItem(weapon, 1);
        }

        private void SetArcherStartInventory()
        {
            var weapon = RecieveStartWeapon<Bow>();
            _inventory.AddItem(weapon, 1);
        }

        private void SetWizardStartInventory()
        {
            var weapon = RecieveStartWeapon<Wand>();
            _inventory.AddItem(weapon, 1);
        }

        private T RecieveStartWeapon<T>() where T : Weapon => _repositoryShell.GetAll<T>().FirstOrDefault(e => e.IsStartItem);

    }
}
