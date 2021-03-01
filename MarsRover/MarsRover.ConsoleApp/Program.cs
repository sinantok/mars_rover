using MarsRover.ConsoleApp.Helpers;
using MarsRover.ConsoleApp.Models;
using MarsRover.ConsoleApp.Models.Enums;
using System;

namespace MarsRover.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("First Test Inputs:");
            Console.WriteLine("5 5");
            Console.WriteLine("1 2 N");
            Console.WriteLine("LMLMLMLMM");

            Plateau plateau = new Plateau(new Coordinate(5, 5));
            RoverHelper roverHelper = new RoverHelper(Direction.N, plateau, new Coordinate(1, 2));
            roverHelper.Operations("LMLMLMLMM");

            string result = string.Format("{0} {1} {2}", roverHelper._ICoordinate.XCoordinate, roverHelper._ICoordinate.YCoordinate, roverHelper.Direction);
            Console.WriteLine($"First Test Output : {result}");

            Console.WriteLine("Second Test Inputs:");
            Console.WriteLine("5 5");
            Console.WriteLine("3 3 E");
            Console.WriteLine("MMRMMRMRRM");

            plateau = new Plateau(new Coordinate(5, 5));
            roverHelper = new RoverHelper(Direction.E, plateau, new Coordinate(3, 3));
            roverHelper.Operations("MMRMMRMRRM");

            result = string.Format("{0} {1} {2}", roverHelper._ICoordinate.XCoordinate, roverHelper._ICoordinate.YCoordinate, roverHelper.Direction);
            Console.WriteLine($"Second Test Output : {result}");

            Console.ReadLine();
        }
    }
}
