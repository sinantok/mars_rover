using MarsRover.ConsoleApp.Models.Enums;

namespace MarsRover.ConsoleApp.Interfaces
{
    public interface IStrategy
    {
        Direction Apply(Direction RoverDirection);
    }
}