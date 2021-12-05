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
            // to do 16 good soul - 200 bad soul - 7 tresure - other empty
            Random generator = new Random();
            return (TypesOfCells)generator.Next(0, 3);
        }

    }
}
