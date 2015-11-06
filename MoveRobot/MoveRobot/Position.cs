using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MoveRobot
{
    public class Position
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Position(int startingX, int startingY)
        {
            X = startingX;
            Y = startingY;
        }

        public override string ToString()
        {
            return String.Format("({0}, {1})", X, Y);
        }

    }
}
