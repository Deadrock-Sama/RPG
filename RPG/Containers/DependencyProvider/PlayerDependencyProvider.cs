using Castle.MicroKernel.Registration;
using Castle.Windsor;
using RPG.Components.Menus;
using RPG.Components.Menus.PlayerInfoPageComponent;
using RPG.Components.Menus.PlayerInfoPageComponent.Items;
using RPG.Components.PlayerComponent;
using System.Collections.Generic;

namespace RPG.Components.Containers
{
    public class PlayerDependencyProvider : IDependencyProvider
    {
        private readonly Player _player;

        public PlayerDependencyProvider(Player player)
        {
            _player = player;
        }

        public IEnumerable<IRegistration> GetRegistrations()
        {
            yield return Component.For<PlayerBasicInfo>()
                    .Instance(_player.Info);

            yield return Component.For<PlayerBasicInfoShower>();

            yield return Component.For<PlayerInfoPage, IMenu>();

            yield return Component.For<PlayerInfoPageShower>();
            
            yield return Component.For<Player>()
                    .Instance(_player);
            
            yield return Component.For<IPlayerInfoPageMenuItem>()
                    .ImplementedBy<ConfirmMenuItem>();
           
        }
    }

}
