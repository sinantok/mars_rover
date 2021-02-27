using MarsRover.ConsoleApp.Interfaces;
using MarsRover.ConsoleApp.Models.Enums;

namespace MarsRover.ConsoleApp.Concretes
{
    public class RoverHelper : IRoverHelper
    {
        public Direction Direction { get; set; }
        public IPlateau _IPlateau { get; set; }
        public ICoordinate _ICoordinate { get; set; }

        public RoverHelper(Direction direction, IPlateau plateau, ICoordinate coordinate)
        {
            Direction = direction;
            _IPlateau = plateau;
            _ICoordinate = coordinate;
        }

        public void Operations(string commands)
        {
            throw new System.NotImplementedException();
        }
    }
}
