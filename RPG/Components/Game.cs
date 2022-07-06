using RPG.Components.MainMenuNS;

namespace RPG.Components
{
    public class Game
    {

        public MainMenu MainMenu { get; }

        public Game(MainMenu mainMenu)
        {
            MainMenu = mainMenu;
        }

        public void Start()
        {
        }

        public void Stop()
        {

        }
    }
}
