using System;
using System.Collections.Generic;
using System.Text;

namespace Core.PlayerNS.Classes
{
    public class PlayerClassManager
    {
        private Dictionary<PlayerClasses, PlayerClass> _classes = new();

        public PlayerClassManager()
        {
            _classes.Add(PlayerClasses.Archer, new Archer());
            _classes.Add(PlayerClasses.Wizard, new Wizard());
            _classes.Add(PlayerClasses.Warrior, new Warrior());
        }


        public PlayerClass GetClassInfo(PlayerClasses playerClass) => _classes[playerClass];

    }
}
