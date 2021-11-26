using System;
using System.Collections.Generic;
using System.Text;

namespace RPG
{
    static class FirstSetup 
    {
        public static void startGame()
        {
            greet();
            chooseName();
        }
        private static void greet()
        {
            Console.WriteLine("Hello! It's amazing place to spend your time.");
            Console.WriteLine("Introduce yourself and choose your class!");
            //will be a story, maybe
        }

        private static void chooseName()
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
        private static string askForName()
        {

            Console.WriteLine("Write your name: ");

            string enteredName = Console.ReadLine();
            return enteredName;
        }
        private static bool confirmName(string name)
        {
            Console.WriteLine($"Are you sure to be {name}? yes/no");

            string answer = Console.ReadLine();

            return answer.ToLower() == "yes";
            
        }

        private static void chooseClass()
        {
            


        }
        private static gameClass askForClass()
        {
            Console.WriteLine("Choose class: 0 - warrior, 1 - wizard, 2 - archer");

            int numdOfClass = -1;
            gameClass chosenClass = null;
            bool userMadeChoose = int.TryParse(Console.ReadLine(), out numdOfClass);
            if (userMadeChoose && numdOfClass > -1 && numdOfClass < 4)
            {
                chosenClass = gameClass.Classes[numdOfClass];
            }
            else
            {
                Console.WriteLine("Wrong data was entered");
                chosenClass = askForClass();
            }

            return chosenClass;
            
        }

    }
}
