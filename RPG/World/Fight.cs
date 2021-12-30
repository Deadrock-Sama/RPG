using RPG.World.NPCs.BadSouls;
using System;
using System.Collections.Generic;
using System.Text;

namespace RPG.World
{
    class Fight
    {
        
        private BadSoul enemy;

        public Fight(BadSoul enemy)
        {
            this.enemy = enemy;
        }

        public StatusOfFight startFight()
        {

            bool PlayersTurnIsFirst = this.PlayersTurnIsFirst();
            StatusOfFight statusOfFight = StatusOfFight.fighting;

            if (PlayersTurnIsFirst)
            {
                statusOfFight = enemy.atackEnemy();
                
            }
            else
            {
                statusOfFight = Player.attackPlayer(enemy);
            }

            return statusOfFight;

        }

        private bool PlayersTurnIsFirst()
        {
            Random random = new Random();
            int result = random.Next(0, 1);

            return result == 0;

        }


    }
}
