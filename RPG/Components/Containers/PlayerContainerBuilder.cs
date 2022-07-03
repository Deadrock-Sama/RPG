using Castle.MicroKernel.Registration;
using Castle.Windsor;
using RPG.Components.Menus;
using RPG.Components.Menus.PlayerInfoPageComponent;
using RPG.Components.Menus.PlayerInfoPageComponent.Items;
using RPG.Components.PlayerComponent;
using System;
using System.Collections.Generic;
using System.Text;

namespace RPG.Components.Containers
{
    class PlayerContainerBuilder : ContainerBuilder
    {
        private Player _player;

        public WindsorContainer Create()
        {
            var container = base.Create();
            container.Register(
                Component.For<PlayerBasicInfo>()
                    .Instance(_player.Info),
                Component.For<PlayerBasicInfoShower>()
                    .Instance(new PlayerBasicInfoShower(_player.Info)),
                Component.For<PlayerInfoPage, IMenu>(),
                Component.For<PlayerInfoPageShower>(),
                Component.For<Player>()
                    .Instance(_player),
                Component.For<IPlayerInfoPageMenuItem>()
                    .ImplementedBy<ConfirmMenuItem>());

            return container;

        }

        public PlayerContainerBuilder(Player player)
        {
            _player = player;
        }

    }
}
