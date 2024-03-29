﻿using RPG.World.NPCs.BadSouls;
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

        static public statusOfMovement move()
        {
            direction? directionOfMove = recieveDirection();

            if (directionOfMove == null) { return statusOfMovement.end; };

            statusOfMovement status = Position.Move(directionOfMove);

            return status;
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
            statusOfMovement status = statusOfMovement.successfully;
            while (status != statusOfMovement.end)
            {
                status = move();
            }

            startStaying();

        }

        static private void startInteractWithCell()
        {
            TypesOfCells currTypeOfCell = recieveTypeOfCurrCell();

            switch (currTypeOfCell)
            {
                case TypesOfCells.Empty:
                    break;
                case TypesOfCells.GoodSoul:
                    break;
                case TypesOfCells.BadSoul:
                    startFight();
                    break;
                case TypesOfCells.Treasure:
                    break;
                case TypesOfCells.Exit:
                    break;
                case TypesOfCells.Boss:
                    break;
                default:
                    break;
            }
        }

        static private void startFight()
        {
            BadSoul enemy = new BadSoul();
            enemy.createEnemy();

            Fight fight = new Fight(enemy);
            StatusOfFight status = fight.startFight();

            if (status == StatusOfFight.win)
            {
                Console.WriteLine("Congrats, u won!");
                startStaying();
            }
            else
            {
                Console.WriteLine("hmm... It cannot be true");
            }
        }

        static private void startStaying()
        {
            Console.WriteLine("1 - interact with cell, 2 - open inventory, 3 - continue moving");

            char key = char.ToLower(Console.ReadKey().KeyChar);

            switch (key)
            {
                case '1':
                    startInteractWithCell();
                    break;
                case '2':
                    Console.WriteLine("now you work with inventory");
                    break;
                case '3':
                    Console.WriteLine("now you start moving");
                    startMoving();
                    break;
                default:
                    Console.WriteLine("u didnt do sth");
                    startStaying();
                    break;
            };


        }




        static public TypesOfCells recieveTypeOfCurrCell()
        {
            return recieveCurrCell().getTypeOfCell();
        }
        static private Cell recieveCurrCell() => cells[Position.getX(), Position.getY()];



    }
}
