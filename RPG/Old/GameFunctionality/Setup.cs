using System;
using System.Collections.Generic;
using System.Text;
using RPG.World;

namespace RPG
{
    class Setup 
    {
        public virtual void startGame() 
        {
            Map.generateMap();
        }

    }

}
