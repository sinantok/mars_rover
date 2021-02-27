using MarsRover.ConsoleApp.Interfaces;

namespace MarsRover.ConsoleApp.Models
{
    public class Coordinate : ICoordinate
    {
        public int XCoordinate { get; set; }
        public int YCoordinate { get; set; }

        public Coordinate(int x, int y)
        {
            XCoordinate = x;
            YCoordinate = y;
        }
    }
}
