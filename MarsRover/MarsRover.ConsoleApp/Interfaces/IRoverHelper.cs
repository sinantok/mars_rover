using MarsRover.ConsoleApp.Models.Enums;

namespace MarsRover.ConsoleApp.Interfaces
{
    public interface IRoverHelper
    {
        Direction Direction { get; set; }
        IPlateau _IPlateau { get; set; }
        ICoordinate _ICoordinate { get; set; }
        void Operations(string commands);
    }
}