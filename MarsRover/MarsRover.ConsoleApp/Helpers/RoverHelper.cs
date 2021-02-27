using MarsRover.ConsoleApp.Concretes;
using MarsRover.ConsoleApp.Interfaces;
using MarsRover.ConsoleApp.Models;
using MarsRover.ConsoleApp.Models.Enums;
using System;

namespace MarsRover.ConsoleApp.Helpers
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
            if (ValidationHelper.IsValid(_IPlateau.PlateauPosition, new Coordinate(_ICoordinate.XCoordinate, _ICoordinate.YCoordinate)))
            {
                Context context = new Context();
                foreach (char command in commands)
                {
                    switch (command)
                    {
                        case ('L'):
                            context = new Context(new TurnLeft());
                            Direction = context.ApplyStrategy(Direction);
                            break;
                        case ('R'):
                            context = new Context(new TurnRight());
                            Direction = context.ApplyStrategy(Direction);
                            break;
                        case ('M'):
                            DoIt();
                            break;
                        default:
                            string exceptionMessage = string.Format("Invalid Value: {0}", command);
                            throw new Exception(exceptionMessage);
                    }
                }
            }
            else
            {
                throw new ArgumentException("Your move command is out of area.");
            }
        }

        private void DoIt()
        {
            if (Direction == Direction.N)
            {
                _ICoordinate.YCoordinate++;
            }
            else if (Direction == Direction.E)
            {
                _ICoordinate.XCoordinate++;
            }
            else if (Direction == Direction.S)
            {
                _ICoordinate.YCoordinate--;
            }
            else if (Direction == Direction.W)
            {
                _ICoordinate.XCoordinate--;
            }

            if (!ValidationHelper.IsValid(_IPlateau.PlateauPosition, new Coordinate(_ICoordinate.XCoordinate, _ICoordinate.YCoordinate)))
            {
                throw new ArgumentException("Your move command is out of area.");
            }
        }
    }
}
