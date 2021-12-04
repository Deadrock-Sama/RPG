using System;
using System.Collections.Generic;
using System.Text;

namespace RPG.World
{
    class Cell
    {
        private TypesOfCells typeOfCell;

        public Cell(TypesOfCells typeOfCell)
        {
            this.typeOfCell = typeOfCell;
        }
        public Cell()
        {
            this.typeOfCell = randomType();
        }

        private TypesOfCells randomType()
        {
            Random generator = new Random();
            return (TypesOfCells)generator.Next(0, 3);
        }

    }
}
