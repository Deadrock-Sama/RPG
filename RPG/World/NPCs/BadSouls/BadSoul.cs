using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace RPG.World.NPCs.BadSouls
{
    class BadSoul
    {
        private string id = "zombie";

        private string name;
        private int HP;
        private int ATK;

        public void createEnemy()
        {
            setRandomID();
            readData();
            introduce();
        }

        private void introduce()
        {

            Console.WriteLine($"Greet {name} with HP={HP},ATK={ATK}");

        }

        private void setRandomID()
        {
            id = "zombie";
        }
        private void readData()
        {
            XmlDocument docWithMobs = new XmlDocument();
            docWithMobs.Load($"C:/Users/Вячеслав/source/repos/RPG/RPG/World/NPCs/BadSouls/Mobs.xml");

            XmlElement mobs = docWithMobs.DocumentElement;

            XmlNode mobByID = mobs.SelectSingleNode($"mob[@id='{id}']");

            HP = int.Parse(mobByID["HP"].InnerText);
            name = mobByID["name"].InnerText;
            ATK = int.Parse(mobByID["ATK"].InnerText);

        }

        public StatusOfFight atackEnemy()
        {
            HP -= Player.getATK();

            StatusOfFight status = StatusOfFight.fighting;
            if(HP <= 0)
            {
                status = StatusOfFight.win;
            }
            else
            {
                status = Player.attackPlayer(this);
            }

            return status;
        }

        public int getATK() => ATK;
         
            
        

    }
}
