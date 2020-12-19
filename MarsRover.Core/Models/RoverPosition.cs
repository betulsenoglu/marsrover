using MarsRover.Core.Models.Enums;

namespace MarsRover.Core.Models
{
    public class RoverPosition
    {
        int X { get; set; }
        int Y { get; set; }
        DirectionType Direction { get; set; }
    }
}