using System;
using System.Collections.Generic;
using System.Text;

namespace RPG.World
{
    class Position
    {

        private int X;
        private int Y;
  
        public Position(int X, int Y)
        {
            setY(Y);
            setX(X);
        }

        public bool Move(direction? direction) {

            bool isMoved = false;

            switch (direction)
            {
                case global::direction.top:
                    isMoved = moveY(1);
                    break;
                case global::direction.down:
                    isMoved = moveY(-1);
                    break;
                case global::direction.left:
                    isMoved = moveX(-1);
                    break;
                case global::direction.right:
                    isMoved = moveX(1);
                    break;
                default:
                    break;
            }
            writePosition();
            return isMoved;
        }

        private bool moveX(int movement) => setX(X + movement);

        private bool moveY(int movement) => setY(Y + movement);
        
        private bool setX(int x)
        {
            bool setIsAble = IsCordAble(X);
            if (setIsAble)
            {
                X = x;
            }
            return setIsAble;
        }
        private bool setY(int y)
        {
            bool setIsAble = IsCordAble(Y);
            if (setIsAble)
            {
                Y = y;
            }
            return setIsAble;
        }

        private bool IsCordAble(int cord) { return (cord < 100) && (cord > 0); }
        private void writePosition()
        {
            Console.WriteLine($"[{X},{Y}]");        
        }
    }
}
