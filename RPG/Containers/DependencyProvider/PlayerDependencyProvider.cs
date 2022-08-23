using Castle.MicroKernel.Registration;
using Core.PlayerNS;
using RPG.Components.Menus;
using RPG.Components.PlayerNS;
using RPG.Components.PlayerNS.PlayerPage;
using RPG.Components.PlayerNS.PlayerPage.PlayerActionMenu;
using RPG.Components.PlayerNS.PlayerPage.PlayerActionMenu.Items;
using RPG.Components.PlayerNS.PlayerPage.PlayerInfo;
using System.Collections.Generic;

namespace RPG.Components.Containers
{
    public class PlayerDependencyProvider : IDependencyProvider
    {
        private Player _player;

        public PlayerDependencyProvider(Player player)
        {
            _player = player;
            
        }

        public IEnumerable<IRegistration> GetRegistrations()
        {
            yield return Component.For<PlayerBasicInfo>()
                    .Instance(_player.Info);

            yield return Component.For<PlayerBasicInfoShower>();

            yield return Component.For<PlayerActionMenuShower>();

            yield return Component.For<PlayerActionMenu, IMenu>();

            yield return Component.For<PlayerPageShower>();
            
            yield return Component.For<Player>()
                .Instance(_player);
            
            yield return Component.For<IPlayerInfoPageMenuItem>()
                    .ImplementedBy<ChooseMenuItem>();
           
        }
    }

}
