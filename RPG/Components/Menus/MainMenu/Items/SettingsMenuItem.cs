using System;

namespace RPG
{
    public class SettingsMenuItem : IMenuItem
    {
        public string Name => "Настройки";

        public void Open()
        {
            Console.WriteLine($"Открыт пункт меню {Name}");
        }
    }
}
