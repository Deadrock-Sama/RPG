using System;
using System.Collections.Generic;
using System.Text;

namespace RPG.NPCs.GoodSouls
{
    class BlackSmith : GoodSoul
    {

        public void upgradeWeapon(Weapon weapon)
        {
            if (weapon.CanPlayerUpIt())
            {
                weapon.upgradeWeapon();
            }
            else
            {
                Console.WriteLine("U cannot up this weapon!");            
            }
                       
        }

    }
}
