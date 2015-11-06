using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MoveRobot.Tests.Unit
{
    [TestClass]
    public class RobotOperatorTests
    {
        private Robot _robot;
        private RobotOperator _robotOperator;

        [TestInitialize]
        public void Initialize()
        {
            _robot = new Robot();
            _robotOperator = new RobotOperator(_robot);
        }

        [TestMethod]
        public void CommandRobot_NES_ShouldMoveRobotToPositionX1Y0()
        {
            //arrange
            var commandSequence = "NES";
            var expected = "(1, 0)";

            //act
            _robotOperator.CommandRobot(commandSequence);

            //assert
            Assert.AreEqual(expected, _robot.CurrentPosition.ToString());

        }

        [TestMethod]
        public void CommandRobot_NESW_ShouldMoveRobotToPositionX0Y0()
        {
            //arrange
            var commandSequence = "NESW";
            var expected = "(0, 0)";

            //act
            _robotOperator.CommandRobot(commandSequence);

            //assert
            Assert.AreEqual(expected, _robot.CurrentPosition.ToString());

        }

        [TestMethod]
        public void CommandRobot_NNNES_ShouldMoveRobotToPositionX1Y2()
        {
            //arrange
            var commandSequence = "NNNES";
            var expected = "(1, 2)";

            //act
            _robotOperator.CommandRobot(commandSequence);

            //assert
            Assert.AreEqual(expected, _robot.CurrentPosition.ToString());

        }

        [TestMethod]
        public void CommandRobot_NESX_ShouldMoveRobotToPositionX1Y1()
        {
            //arrange
            var commandSequence = "NESX";
            var expected = "(1, 1)";

            //act
            _robotOperator.CommandRobot(commandSequence);

            //assert
            Assert.AreEqual(expected, _robot.CurrentPosition.ToString());

        }

        [TestMethod]
        public void CommandRobot_NESXX_ShouldMoveRobotToPositionX0Y1()
        {
            //arrange
            var commandSequence = "NESXX";
            var expected = "(0, 1)";

            //act
            _robotOperator.CommandRobot(commandSequence);

            //assert
            Assert.AreEqual(expected, _robot.CurrentPosition.ToString());

        }

        [TestMethod]
        public void CommandRobot_NESXXX_ShouldMoveRobotToPositionX0Y0()
        {
            //arrange
            var commandSequence = "NESXXX";
            var expected = "(0, 0)";

            //act
            _robotOperator.CommandRobot(commandSequence);

            //assert
            Assert.AreEqual(expected, _robot.CurrentPosition.ToString());

        }

        [TestMethod]
        public void CommandRobot_FBA_ShouldReturnX999Y999()
        {
            //arrange
            var commandSequence = "FBA";
            var expected = "(999, 999)";

            //act
            var result = _robotOperator.CommandRobot(commandSequence);

            //assert
            Assert.AreEqual(expected, result);

        }

        [TestMethod]
        public void CommandRobot_7N3W_ShouldMoveRobotToPositionXMinus3Y7()
        {
            //arrange
            var commandSequence = "7N3W";
            var expected = "(-3, 7)";

            //act
            _robotOperator.CommandRobot(commandSequence);

            //assert
            Assert.AreEqual(expected, _robot.CurrentPosition.ToString());

        }

        [TestMethod]
        public void CommandRobot_17N31W_ShouldMoveRobotToPositionXMinus31Y17()
        {
            //arrange
            var commandSequence = "17N31W";
            var expected = "(-31, 17)";

            //act
            _robotOperator.CommandRobot(commandSequence);

            //assert
            Assert.AreEqual(expected, _robot.CurrentPosition.ToString());

        }

        [TestMethod]
        public void CommandRobot_261E2W4S_ShouldMoveRobotToPositionX259YMinus17()
        {
            //arrange
            var commandSequence = "261E2W4S";
            var expected = "(259, -4)";

            //act
            _robotOperator.CommandRobot(commandSequence);

            //assert
            Assert.AreEqual(expected, _robot.CurrentPosition.ToString());

        }

        [TestMethod]
        public void CommandRobot_2EEE2WWWW4SSS_ShouldMoveRobotToPositionXMinus1YMinus6()
        {
            //arrange
            var commandSequence = "2EEE2WWWW4SSS";
            var expected = "(-1, -6)";

            //act
            _robotOperator.CommandRobot(commandSequence);

            //assert
            Assert.AreEqual(expected, _robot.CurrentPosition.ToString());

        }
        
        [TestMethod]
        public void CommandRobot_7NX_ShouldMoveRobotToPositionX0Y6()
        {
            //arrange
            var commandSequence = "7NX";
            var expected = "(0, 6)";

            //act
            _robotOperator.CommandRobot(commandSequence);

            //assert
            Assert.AreEqual(expected, _robot.CurrentPosition.ToString());

        }
    }
}
