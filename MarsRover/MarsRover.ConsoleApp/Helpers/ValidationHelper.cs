using MarsRover.ConsoleApp.Models;

namespace MarsRover.ConsoleApp.Helpers
{
    public static class ValidationHelper
    {
        public static bool IsValid(Coordinate plateauSize, Coordinate roverPoint)
        {
            var isValidX = roverPoint.XCoordinate >= 0 && roverPoint.XCoordinate <= plateauSize.XCoordinate;
            var isValidY = roverPoint.YCoordinate >= 0 && roverPoint.YCoordinate <= plateauSize.YCoordinate;
            return isValidX && isValidY;
        }
    }
}
