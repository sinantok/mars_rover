using MarsRover.ConsoleApp.Interfaces;
using MarsRover.ConsoleApp.Models.Enums;

namespace MarsRover.ConsoleApp.Concretes
{
    class TurnRight : IStrategy
    {
        public Direction Apply(Direction direction)
        {
            direction = (direction + 1) > Direction.W ? Direction.N : direction + 1;
            return direction;
        }
    }
}
