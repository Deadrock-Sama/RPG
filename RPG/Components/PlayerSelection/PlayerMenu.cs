using Castle.Windsor;
using Core.PlayerNS;
using RPG.Components.MainMenuNS.Items;
using RPG.Components.Menus;
using RPG.Components.PlayerNS;
using RPG.Components.PlayerNS.PlayerPage.PlayerInfo;
using RPG.Components.PlayerSelection.Items;
using RPG.Navigation;
using System.Collections.Generic;

namespace RPG.Components.PlayerSelection
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
