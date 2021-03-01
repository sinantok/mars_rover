using MarsRover.ConsoleApp.Helpers;
using MarsRover.ConsoleApp.Models;
using MarsRover.ConsoleApp.Models.Enums;
using NUnit.Framework;

namespace MarsRover.TestApp
{
    public class RoverTest
    {
        RoverHelper _roverHelper;
        Plateau _plateau;
        [SetUp]
        public void Setup()
        {
        }

        [TestCase("LMLMLMLMM", "1 3 N")]
        public void TestOne(string movement, string position)
        {
            _plateau = new Plateau(new Coordinate(5, 5));
            _roverHelper = new RoverHelper(Direction.N, _plateau, new Coordinate(1, 2));
            _roverHelper.Operations(movement);
            string result = string.Format("{0} {1} {2}", _roverHelper._ICoordinate.XCoordinate, _roverHelper._ICoordinate.YCoordinate, _roverHelper.Direction);

            Assert.AreEqual(result, position);
        }

        [TestCase("MMRMMRMRRM", "5 1 E")]
        public void TestTwo(string movement, string position)
        {
            _plateau = new Plateau(new Coordinate(5, 5));
            _roverHelper = new RoverHelper(Direction.E, _plateau, new Coordinate(3, 3));
            _roverHelper.Operations(movement);
            string result = string.Format("{0} {1} {2}", _roverHelper._ICoordinate.XCoordinate, _roverHelper._ICoordinate.YCoordinate, _roverHelper.Direction);

            Assert.AreEqual(result, position);
        }
    }
}
