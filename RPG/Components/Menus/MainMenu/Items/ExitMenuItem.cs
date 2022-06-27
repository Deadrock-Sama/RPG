using System;

namespace RPG
{
    public class ExitMenuItem : IMainMenuItem
    {
        public string Name => "Выйти"; 

        public void Open()
        {
            Console.WriteLine("Вы уверерены, что хотите выйти?");
        }
    }
}
