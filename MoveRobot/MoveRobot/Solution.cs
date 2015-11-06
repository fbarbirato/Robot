using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoveRobot
{
    class Solution
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Type robot command: ");

            var command = Console.ReadLine();

            Console.WriteLine("Robot Position: " + moveRobot(command));

            Console.ReadKey();
        }

        static string moveRobot(string s)
        {
            var robotOperator = new RobotOperator(new Robot());

            return robotOperator.CommandRobot(s);
        }
    }
}
