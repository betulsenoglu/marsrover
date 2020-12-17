using System.Collections.Generic;

namespace MarsRover.Core.Models
{
    public class Plateau
    {
        int GridX { get; set; }
        int GridY { get; set; }
        IList<Rover> Rovers { get; set; }
    }
}