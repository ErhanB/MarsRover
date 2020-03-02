using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover
{
    class Rover
    {
        public Position pos = new Position();
        public Rover(string positionCommand)
        {
            char[] posAndDir = positionCommand.Split(' ').SelectMany(x => x.ToCharArray()).ToArray();
            pos.X = (int)char.GetNumericValue(posAndDir[0]);
            pos.Y = (int)char.GetNumericValue(posAndDir[1]);
            pos.Direction= posAndDir[2];
         
        }
        private void Move()
        {   
                switch (pos.Direction)
            {
                case 'N':
                    pos.Y++;
                    break;
                case 'S':
                    pos.Y--;
                    break;
                case 'E':
                    pos.X++;
                    break;
                case 'W':
                    pos.X--;
                    break;
                default:
                    Console.WriteLine("Invalid input detected.");
                    break;
            }

        }
        public Position ExecuteCommand(string navigationCommand)
        {
            List<char> nav = navigationCommand.ToCharArray().ToList<char>();
        
            foreach (char command in nav)
            {
                if (command == 'M')
                    Move();
                else pos.Direction = NavigationLookup.GetDirection(pos.Direction, command);
               
            }

            return pos;
        }
    }
}
