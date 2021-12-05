using System;
using System.Collections.Generic;
using System.Text;

namespace RPG.World
{
    static class Map
    {
        static private Cell[,] cells = new Cell[100, 100];
        static private Position Position = new Position(0, 0);
        static public void generateMap()
        {
            generateCells();
            startMoving();

        }

        static private void generateCells()
        {
            for (int i = 0; i < 100; i++)
            {
                for (int j = 0; j < 100; j++)
                {

                    cells[i, j] = new Cell();

                }
            }

        }

        static public bool move()
        {
            direction? directionOfMove = recieveDirection();
            bool isMoved = Position.Move(directionOfMove);

            return isMoved;
        }
        static private direction? recieveDirection()
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

        static private void startMoving()
        {
            Console.WriteLine("Use w/s/a/d to move");
            while (true)
            {
                move();
            }

        }

    }
}
