using System;
using System.Collections.Generic;
using System.Text;

namespace RPG.World
{
    internal class Map
    {
        private Cell[,] cells;
        private Position Position = new Position(0, 0);

        private void generateMap()
        {
            for (int i = 0; i < 100; i++)
            {
                for (int j = 0; j < 100; j++)
                {

                    cells[i, j] = new Cell();


                }
            }
        
        }

        public bool move() 
        {
            direction? directionOfMove = recieveDirection();

            return true;
        }
        private direction? recieveDirection()
        {
            char key = char.ToLower(Console.ReadKey().KeyChar);

            switch (key)
            {
                case 'w':
                    return direction.top;     
                case 's':
                    return direction.down;
                case 'a':
                    return direction.left;
                case 'd':
                    return direction.right;
                default:
                    return null;
            };

        }

    }
}
