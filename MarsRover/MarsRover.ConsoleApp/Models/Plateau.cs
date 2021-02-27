using MarsRover.ConsoleApp.Interfaces;

namespace MarsRover.ConsoleApp.Models
{
    public class Plateau : IPlateau
    {
        public Coordinate PlateauPosition { get; set; }

        public Plateau(Coordinate position)
        {
            PlateauPosition = position;
        }
    }
}
