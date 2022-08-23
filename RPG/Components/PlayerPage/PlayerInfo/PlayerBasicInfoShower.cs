using Core.PlayerNS;
using RPG.ConsoleInteraction;

namespace RPG.Components.PlayerNS.PlayerPage.PlayerInfo
{
    public class PlayerBasicInfoShower
    {
        private readonly PlayerBasicInfo _playerInfoPage;
        private readonly ConsoleManager _consoleManager;

        public PlayerBasicInfoShower(PlayerBasicInfo playerInfoPage, ConsoleManager consoleManager)
        {
            _playerInfoPage = playerInfoPage;
            _consoleManager = consoleManager;
        }

        public void Show()
        {
            _consoleManager.Show(_playerInfoPage.Description);
        }

    }
}
