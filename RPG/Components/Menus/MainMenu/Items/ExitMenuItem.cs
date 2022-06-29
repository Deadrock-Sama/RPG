using System;

namespace RPG
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
