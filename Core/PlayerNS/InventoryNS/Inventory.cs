using Core.DBInteraction;
using RPG.Components.PlayerNS.InventoryNS.Resources.Food;
using System.Collections.Generic;
using System.Linq;

namespace Core.PlayerNS.InventoryNS
{
    public class Inventory
    {
        private readonly IRepositoryShell _repositoryShell;
        private List<ItemController> _inventory;

        public Inventory(IRepositoryShell repositoryShell)
        {
            _repositoryShell = repositoryShell;
            _inventory = _repositoryShell.GetAll<ItemController>();
        }

        public void AddItem(Item item, int count)
        {
            var controller = _inventory.FirstOrDefault(e => e.Item == item);

            if (controller == null)
            {
                controller = new ItemController { Item = item, Count = count };
                _inventory.Add(controller);
            }
            else
            {
                controller.Count += count;
            }
            _repositoryShell.AddOrUpdate(controller);
        }

    }
}
