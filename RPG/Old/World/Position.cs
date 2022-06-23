using System;
using System.Collections.Generic;
using System.Text;

namespace RPG.World
{
    class Position
    {

        private int X;
        private int Y;

        public int getX() => X;
        public int getY() => Y;
        public Position(int X, int Y)
        {
            setY(Y);
            setX(X);
        }

        public statusOfMovement Move(direction? direction)
        {

            statusOfMovement status = statusOfMovement.successfully;

            switch (direction)
            {
                case global::direction.top:
                    status = moveY(1);
                    break;
                case global::direction.down:
                    status = moveY(-1);
                    break;
                case global::direction.left:
                    status = moveX(-1);
                    break;
                case global::direction.right:
                    status = moveX(1);
                    break;
                default:
                    break;
            }
            if(status == statusOfMovement.successfully)
            {
                writePosition();
            }
            
            return status;
        }

        private statusOfMovement moveX(int movement)
        {

            bool isSetted = setX(X + movement);

            statusOfMovement status = statusOfMovement.successfully;
            if (!isSetted)
            {
                status = statusOfMovement.outOfRange;
            }
            return status;

        }

        private statusOfMovement moveY(int movement)
        {

            bool isSetted = setY(Y + movement);

            statusOfMovement status = statusOfMovement.successfully;
            if (!isSetted)
            {
                status = statusOfMovement.outOfRange;
            }
            return status;

        }

        private bool setX(int x)
        {
            bool setIsAble = IsCordAble(x);
            if (setIsAble)
            {
                X = x;
            }
            return setIsAble;
        }
        private bool setY(int y)
        {
            bool setIsAble = IsCordAble(y);
            if (setIsAble)
            {
                Y = y;
            }
            return setIsAble;
        }

        private bool IsCordAble(int cord) { return (cord < 100) && (cord > -1); }
        private void writePosition()
        {
            Console.WriteLine($"[{X},{Y}], {Map.recieveTypeOfCurrCell()}");

        }


    }
}
