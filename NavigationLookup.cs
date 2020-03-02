using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover
{
    class NavigationLookup
    {
        public static IReadOnlyCollection<(char FacingDirection, char Instruction, char NewDirection)> Directions
            = new List<(char FacingDirection, char Instruction, char NewDirection)>
            {
                ('N', 'L', 'W'),
                ('W', 'L', 'S'),
                ('S', 'L', 'E'),
                ('E', 'L', 'N'),
                ('N', 'R', 'E'),
                ('E', 'R', 'S'),
                ('S', 'R', 'W'),
                ('W', 'R', 'N')
            };
        public static char GetDirection(char direction, char command)
        {
            var lookupValue = NavigationLookup.Directions
                    .FirstOrDefault(lookup => lookup.FacingDirection == direction && lookup.Instruction == command);
            return lookupValue.NewDirection;

        }
    }
}
