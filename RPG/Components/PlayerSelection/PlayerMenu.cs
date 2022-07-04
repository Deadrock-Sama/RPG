using Castle.Windsor;
using RPG.Components.Menus.PlayerMenu.Items;
using RPG.Components.Navigation;
using RPG.Components.PlayerComponent;
using System.Collections.Generic;
using System.Linq;

namespace RPG.Components.Menus.PlayerMenu
{

    public class PlayerMenu : IMenu
    {
        public List<IMenuItem> MenuItems { get; } = new List<IMenuItem>();


        public PlayerMenu(IEnumerable<IPlayerMenuItem> playerMenuItems, PlayerRepository repository, WindsorContainer container, AppNavigator navigator)
        {
            foreach (PlayerBasicInfo player in repository.BasicInfos)
            {
                MenuItems.Add(new PlayerMenuItem(player, repository, container, navigator));
            }
            foreach (var item in playerMenuItems)
            {
                MenuItems.Add(item);
            }
        }
    }
}
