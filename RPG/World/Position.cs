using System;
using System.Collections.Generic;
using System.Text;

namespace RPG.World
{
    struct Position
    {
        public int X {
            get {
                return X;
            }
            set {
                setX(value);
            } 
        }
        public int Y
        {
            get
            {
                return Y;
            }
            set
            {
                setY(value);
            }
        }

        public Position(int X, int Y)
        {
            setX(X);
            setY(Y);
        }

        public bool moveX(int movement) => setX(X + movement);

        public bool moveY(int movement) => setY(Y + movement);
        
        private bool setX(int X)
        {
            bool setIsAble = isCordAble(X);
            if (setIsAble)
            {
                this.X = X;
            }
            return setIsAble;
        }
        private bool setY(int Y)
        {
            bool setIsAble = isCordAble(Y);
            if (setIsAble)
            {
                this.Y = Y;
            }
            return setIsAble;
        }

        private bool isCordAble(int cord) => (cord <= 100) && (cord >= 0);

    }
}
