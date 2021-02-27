using MarsRover.ConsoleApp.Interfaces;
using MarsRover.ConsoleApp.Models.Enums;

namespace MarsRover.ConsoleApp.Concretes
{
    public class Context
    {
        private IStrategy _IStrategy;

        public Context()
        {
        }

        public Context(IStrategy strategy)
        {
            this._IStrategy = strategy;
        }

        public Direction ApplyStrategy(Direction roverDirection)
        {
            return _IStrategy.Apply(roverDirection);
        }
    }
}
