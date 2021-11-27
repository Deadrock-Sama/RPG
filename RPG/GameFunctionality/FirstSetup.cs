using System;

namespace RPG
{
    class FirstSetup : Setup
    {
        public override void startGame()
        {
            greet();
            createPlayer();
        }
        private void greet()
        {
            Console.WriteLine("Hello! It's amazing place to spend your time.");
            Console.WriteLine("Introduce yourself and choose your class!");
            //will be a story, maybe
        }

        private void createPlayer()
        {
            chooseName();
            chooseClass();
            Console.WriteLine($"Nice to meet you {Player.PlayerClass} {Player.Name}!");
        }

        private void chooseName()
        {
            string enteredName = askForName();
            string confirmedName = "";

            while (confirmedName == "")
            {

                if (confirmName(enteredName))
                {
                    confirmedName = enteredName;
                }
                else
                {
                    enteredName = askForName();
                }
            }

            Player.Name = confirmedName;
        }
        private string askForName()
        {

            Console.WriteLine("Write your name: ");

            string enteredName = Console.ReadLine();
            return enteredName;
        }
        private bool confirmName(string name)
        {
            Console.WriteLine($"Are you sure to be {name}? yes/no");

            string answer = Console.ReadLine();

            return answer.ToLower() == "yes";

        }

        private void chooseClass()
        {

            gameClass enteredClass = askForClass();
            gameClass confirmedClass = null;

            while (confirmedClass == null)
            {

                if (confirmClass(enteredClass))
                {
                    confirmedClass = enteredClass;
                }
                else
                {
                    enteredClass = askForClass();
                }
            }

            Player.PlayerClass = confirmedClass;
        }
        private static gameClass askForClass()
        {
            Console.WriteLine("Choose class: 0 - warrior, 1 - wizard, 2 - archer");

            int numbOfClass = -1;
            gameClass chosenClass = null;
            bool userMadeChoose = int.TryParse(Console.ReadLine(), out numbOfClass);
            if (userMadeChoose && numbOfClass > -1 && numbOfClass < 4)
            {
                chosenClass = gameClass.Classes[numbOfClass];
            }
            else
            {
                Console.WriteLine("Wrong data was entered");
                chosenClass = askForClass();
            }

            return chosenClass;

        }
        private bool confirmClass(gameClass enteredClass)

        {
            Console.WriteLine($"Are you sure to be {enteredClass.ToString()}? yes/no");

            string answer = Console.ReadLine();

            return answer.ToLower() == "yes";
        }

    }
}
