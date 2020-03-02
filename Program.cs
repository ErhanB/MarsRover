using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover
{
    class Program
    {
        static void Main(string[] args)
        {
            string FirstRoverStatus;
            string FirstRoverCommand;
            string SecondRoverStatus;
            string SecondRoverCommand;
            Console.WriteLine("Welcome to Mars Rover Command Center. For test input, enter 't'");
            string MapSize = Console.ReadLine();
            if (MapSize.Equals("t"))
            {
                MapSize = "5 5";
                FirstRoverStatus = "1 2 N";
                FirstRoverCommand = "LMLMLMLMM";
                SecondRoverStatus = "3 3 E";
                SecondRoverCommand = "MMRMMRMRRM";
                Console.WriteLine(FirstRoverStatus);
                Console.WriteLine(FirstRoverCommand);
                Console.WriteLine(SecondRoverStatus);
                Console.WriteLine(SecondRoverCommand);
            }
            else { 
            FirstRoverStatus = Console.ReadLine();
            FirstRoverCommand = Console.ReadLine();
            SecondRoverStatus = Console.ReadLine();
            SecondRoverCommand = Console.ReadLine();
            }          

            Rover rover1 = new Rover(FirstRoverStatus);
            Rover rover2 = new Rover(SecondRoverStatus);
            Position pos1=rover1.ExecuteCommand(FirstRoverCommand);
            Position pos2 = rover2.ExecuteCommand(SecondRoverCommand);
            Console.WriteLine("Commands completed. Status of Rover-1:");
            Console.WriteLine(pos1.X.ToString() + " " + pos1.Y.ToString() + " " + pos1.Direction.ToString());
            Console.WriteLine("Status of Rover-2:");
            Console.WriteLine(pos2.X.ToString() + " " + pos2.Y.ToString() + " " + pos2.Direction.ToString());
            Console.WriteLine("Enter to exit");
            Console.ReadKey();
        }
        
    }
}

