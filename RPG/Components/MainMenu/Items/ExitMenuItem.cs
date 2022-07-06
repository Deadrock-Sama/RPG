using System;

namespace RPG.Components.MainMenuNS.Items
{
    public class ExitMenuItem : IMainMenuItem
    {
        public string Name => "Выйти";

        public void Open()
        {
            Environment.Exit(0);
        }
    }
}
