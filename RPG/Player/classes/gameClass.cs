using System;
using System.Collections.Generic;
using System.Text;

namespace RPG
{
    class gameClass
    {
        private static gameClass[] arrOfClasses = new gameClass[3]
        {
              new classWarrior(),
              new classWizard(),
              new classArcher()
        };
        public static gameClass[] Classes { get { return arrOfClasses; } }
    }
}
