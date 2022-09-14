using Core.DBInteraction;

namespace Core.PlayerNS.InventoryNS
{
    public class Inventory
    {
        //Нужно получать инвентарь игрока
        //Нужно понимать, а какой именно это предмет(еда/меч/шлем?)

        private readonly IRepositoryShell _repositoryShell;
        private List<ItemController> _inventory;
        private readonly Player _player;

        public Inventory(IRepositoryShell repositoryShell, Player player)
        {
            _repositoryShell = repositoryShell;
            _player = player;
            _inventory = _repositoryShell.GetAll<ItemController>()
                                         .Where(e => e.Player == _player)
                                         .ToList();
            
        }

        public void AddItem(Item item, int count)
        {
            var controller = _inventory.FirstOrDefault(e => e.Item == item);

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

        public void RecieveInventory()
        {
            ;

        }



    }
}
