using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoveRobot
{
    public class RobotOperator
    {
        private IRobot _robot { get; set; }
        
        public RobotOperator(IRobot robotToOperate)
        {
            _robot = robotToOperate;
        }

        public string CommandRobot(string commandSequence)
        {
            if (CommandNotValid(commandSequence))
            {
                return "(999, 999)";
            }

            commandSequence = Magnify(commandSequence);

            commandSequence = RemoveDeletionCommands(commandSequence);

            char[] commands = commandSequence.ToCharArray();

            foreach (var command in commands)
            {
                _robot.Move(GetDirectionByChar(command));
            }

            return _robot.CurrentPosition.ToString();
        }

        private bool CommandNotValid(string commandSequence)
        {
            return !(commandSequence.Contains("N") 
                || commandSequence.Contains("S")
                || commandSequence.Contains("E")
                || commandSequence.Contains("W")
                || commandSequence.Contains("X")
                );
        }

        private string RemoveDeletionCommands(string commandSequence)
        {
            string commands = commandSequence.Split('X')[0];
            
            int countX = commandSequence.Split('X').Length - 1;

            string finalCommand = commands.Substring(0, commands.Length - countX);

            return finalCommand;
        }

        private string Magnify(string commandSequence)
        {
            bool toMagnify = false;
            string number = "";
            string magnifiedCommand = "";
            string newCommandSequence = "";

            for (int i = 0; i < commandSequence.Length; i++)
            {

                char currentCommand = commandSequence[i];

                if (Char.IsNumber(currentCommand))
                {
                    toMagnify = true;
                    number += currentCommand.ToString();

                    continue;
                }

                if (toMagnify)
                {
                    for (int j = 0; j < Convert.ToInt32(number); j++)
                    {
                        magnifiedCommand += currentCommand.ToString();
                    }

                    newCommandSequence += magnifiedCommand;

                    toMagnify = false;
                    number = "";
                    magnifiedCommand = "";
                }
                else
                {
                    newCommandSequence += currentCommand.ToString();
                }
            }

            return newCommandSequence;

        }

        private Direction GetDirectionByChar(char command)
        {
            switch (command)
            {
                case ('N') :
                    return Direction.NORTH;
                case ('S'):
                    return Direction.SOUTH;
                case ('E'):
                    return Direction.EAST;
                case ('W'):
                    return Direction.WEST;
            }

            return Direction.NONE;
        }
    }
}
