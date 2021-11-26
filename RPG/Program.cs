using System;

namespace RPG
{
    class Program
    {
        static void Main(string[] args)
        {

            bool firstStart = true;

            if (firstStart)
            {
                FirstSetup.startGame();
            }

            Console.ReadLine();
        }

      

        private static void createPlayer()
        {

            Console.WriteLine("Hello!");
          
            Console.WriteLine($"You wanna be {Player.PlayerClass.ToString()} {Player.Name}? yes/no");

            if (Console.ReadLine() == "yes")
            {
                Console.WriteLine("Congats! But it's the end of game. At the least now...");
            }
            else
            {
                Console.WriteLine("OK! Fortunately, it's the end of game.");
            }


        }

        private static void greetFirstTime()
        {
           
        }

       

    }
}
