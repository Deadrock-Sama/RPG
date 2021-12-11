using System;

namespace RPG
{
    class Program
    {
        static void Main(string[] args)
        {
            bool firstStart = true;

            Setup setup = new RegularSetup();
            if (firstStart)
            {
                setup = new FirstSetup();
            }
            setup.startGame();

            Console.ReadLine();
        }
    }
}
