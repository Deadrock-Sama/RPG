using RPG.Components.PlayerComponent;

namespace RPG.Components.Menus.PlayerInfoPageComponent
{
    public class PlayerInfoShower
    {
        private readonly PlayerBasicInfo _playerInfoPage;
        private readonly ConsoleManager _consoleManager;

        public PlayerInfoShower(PlayerBasicInfo playerInfoPage, ConsoleManager consoleManager)
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
