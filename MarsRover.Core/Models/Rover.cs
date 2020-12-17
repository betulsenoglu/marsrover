using System.Collections.Generic;
using MarsRover.Core.Interfaces;

namespace MarsRover.Core.Models
{
    public class Rover
    {
        public IList<ICommand> Commands { get; set; }
        public RoverPosition CurrentPosition { get; set; }
        public Plateau PlateauGrid { get; set; }

    }
}