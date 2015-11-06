using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MoveRobot
{
    public interface IRobot
    {
        Position CurrentPosition { get; set; }
        void Move(Direction direction);
    }
}
