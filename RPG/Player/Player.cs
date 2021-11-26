using System;
using System.Collections.Generic;
using System.Text;

namespace RPG
{
    static class Player
    {
        private static string name;
        private static int level;

        private static int currEXP;
        private static int neededEXP;

        private static int currHP;
        private static int maxHP;

        private static int currStamina;
        private static int maxStamina;

        private static int currMana;
        private static int maxMana;

        private static int money;
        
        private static Weapon weapon;
        private static Inventory inventrory;
        private static gameClass playerClass;



        public static string Name { get { return name; } set { name = value; } }
        
        public static gameClass PlayerClass { get { return playerClass; } set { playerClass = value; } }

        public static bool spendMoney(int amount)
        {
            bool result = isEnoughMoney(amount);
            if (result)
            {
                money = money - amount;
            }

            return result;
        }

        public static void addMoney(int amount)
        {
            money = money + amount;
        }

        public static bool isEnoughMoney(int amount) => amount <= money;
        
    }
}
