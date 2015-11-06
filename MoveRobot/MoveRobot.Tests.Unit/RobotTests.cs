using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MoveRobot.Tests.Unit
{
    [TestClass]
    public class RobotTests
    {
        private Robot _robot;

        [TestInitialize]
        public void Initialize()
        {
            _robot = new Robot();
        }

        [TestMethod]
        public void Move_North_ShouldMoveToX0Y1()
        {
            //arrange
            var expected = "(0, 1)";

            //act
            _robot.Move(Direction.NORTH);

            //assert
            Assert.AreEqual(expected, _robot.CurrentPosition.ToString());
        }

        [TestMethod]
        public void Move_South_ShouldMoveToX0YMinus1()
        {
            //arrange
            var expected = "(0, -1)";

            //act
            _robot.Move(Direction.SOUTH);

            //assert
            Assert.AreEqual(expected, _robot.CurrentPosition.ToString());
        }

        [TestMethod]
        public void Move_East_ShouldMoveToX1Y0()
        {
            //arrange
            var expected = "(1, 0)";

            //act
            _robot.Move(Direction.EAST);

            //assert
            Assert.AreEqual(expected, _robot.CurrentPosition.ToString());
        }

        [TestMethod]
        public void Move_WestShouldMoveToX1Y0()
        {
            //arrange
            var expected = "(-1, 0)";

            //act
            _robot.Move(Direction.WEST);

            //assert
            Assert.AreEqual(expected, _robot.CurrentPosition.ToString());
        }
    }
}
