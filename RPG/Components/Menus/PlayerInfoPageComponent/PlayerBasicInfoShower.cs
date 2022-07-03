using RPG.Components.PlayerComponent;
using System;
using System.Collections.Generic;
using System.Text;

namespace RPG.Components.Menus.PlayerInfoPageComponent
{
    public class PlayerBasicInfoShower 
    {
        private PlayerBasicInfo _playerBasicInfo;

        public PlayerBasicInfoShower(PlayerBasicInfo playerBasicInfo)
        {
            _playerBasicInfo = playerBasicInfo;
        }

        public void Show()
        {
            Console.WriteLine(_playerBasicInfo.Name);
            Console.WriteLine(_playerBasicInfo.Description);
        }

    }
}
