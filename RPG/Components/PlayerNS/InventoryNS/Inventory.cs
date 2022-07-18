using RPG.Components.PlayerNS.InventoryNS.Resources.Food;
using RPG.DBInteraction;
using System.Collections.Generic;
using System.Linq;

namespace RPG.Components.PlayerNS.InventoryNS
{
    public class Inventory
    {
        private readonly IRepositoryShell _repositoryShell;
        private List<InventoryItemController> _inventory;


        public Inventory(IRepositoryShell repositoryShell)
        {
            _repositoryShell = repositoryShell;


            _inventory = _repositoryShell.GetAll<InventoryItemController>();
        }

        public void AddItem(Item item, int count)
        {
            var controller = _inventory.FirstOrDefault(ei => ei.Item == item);

            if (controller == null)
            {
                controller = new InventoryItemController { Item = item, Count = count };
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
