using System;
using System.Collections.Generic;
using System.Text;

namespace RPG
{
    class Weapon : Item
    {

        private bool isEquiped;
        private gameClass forClass;
        private int ATK;
        private int countOfUpgrades;
        private int baseCostOfUpgrade = 100;
        private int recieveCostOfUprade() => (int)Math.Pow(baseCostOfUpgrade, (countOfUpgrades + 1));

        public bool CanPlayerUpIt()
        {
            int cost = recieveCostOfUprade();

            return Player.isEnoughMoney(cost);
        }

        private void upgradeATK()
        {
            ATK = (int)(ATK * 1.4);
        }

        public void upgradeWeapon() {

            if (CanPlayerUpIt())
            {
                Player.spendMoney(recieveCostOfUprade());
                upgradeATK();
                countOfUpgrades++;
            }

        }
    
    }
}
