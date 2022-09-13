using Core.DBInteraction;

namespace Core.PlayerNS.InventoryNS
{
    public class Inventory
    {
        private readonly IRepositoryShell _repositoryShell;
        private List<ItemController> _inventory;
        private readonly Player _player;

        public Inventory(IRepositoryShell repositoryShell, Player player)
        {
            _repositoryShell = repositoryShell;
            _inventory = _repositoryShell.GetAll<ItemController>();
            _player = player;
        }

        public void AddItem(Item item, int count)
        {
            var controller = _inventory.FirstOrDefault(e => (e.Item == item && e.Player == _player));

            if (controller == null)
            {
                controller = new ItemController { Item = item, Count = count, Player = _player };
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
