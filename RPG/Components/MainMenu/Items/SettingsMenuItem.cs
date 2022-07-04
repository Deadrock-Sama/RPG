using System;

namespace RPG
{
    public class SettingsMenuItem : IMainMenuItem
    {
        public string Name => "Настройки";

        public void Open()
        {
            Console.WriteLine($"Открыт пункт меню {Name}");
        }
    }
}
