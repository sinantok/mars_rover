using MarsRover.ConsoleApp.Interfaces;
using MarsRover.ConsoleApp.Models.Enums;

namespace MarsRover.ConsoleApp.Concretes
{
    public class TurnLeft : IStrategy
    {
        public Direction Apply(Direction direction)
        {
            direction = (direction - 1) < Direction.N ? Direction.W : direction - 1;
            return direction;
        }
    }
}
