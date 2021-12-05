using System;
using System.Collections.Generic;
using System.Text;

namespace RPG
{
     class RegularSetup : Setup
    {
        public override void startGame()
        {
            greet();
            base.startGame();
        }
        private void greet()
        {
            Console.WriteLine("Welcome. Again.");
        }
        private void loadPlayer()
        {
            throw new Exception();
        }
       

    }
}
