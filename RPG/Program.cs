using System;

namespace RPG
{

    class Program
    {
        static void Main(string[] args)
        {
            var cm = new ConsoleManager();


            var game = new Game();
            var menuShower = new ConsoleMenuShower(game.MainMenu,cm);

            menuShower.Show();

            //cm.ShowAndReadLine("Введите строку");



            while (true)
            {

            }

            //bool firstStart = true;

            //Setup setup = new RegularSetup();
            //if (firstStart)
            //{
            //    setup = new FirstSetup();
            //}
            //setup.startGame();

            //Console.ReadLine();
        }

        private static void Cm_LineWritten(string obj)
        {
            Console.WriteLine($"Введена строка {obj}");
        }

        private static void Cm_KeyPressed(ConsoleKey obj)
        {
            Console.WriteLine($"Нажата клавиша {obj}");
        }
    }
}
