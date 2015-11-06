using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoveRobot
{
    public class Robot : IRobot
    {
        public Robot()
        {
            CurrentPosition = new Position(0, 0);
        }

        public Position CurrentPosition { get; set; }

        public void Move(Direction direction)
        {
            switch (direction)
            {
                case (Direction.NORTH):
                    CurrentPosition.Y += 1;
                    break;
                case (Direction.SOUTH):
                    CurrentPosition.Y += -1;
                    break;
                case (Direction.EAST):
                    CurrentPosition.X += 1;
                    break;
                case (Direction.WEST):
                    CurrentPosition.X += -1;
                    break;
                case (Direction.NONE):
                    break;

            }
        }
    }
}
