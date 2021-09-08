using System;

namespace Zork
{
    class Program
    {
        private static string Location
        {
            get
            {
                return Rooms[LocationColumn];
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Zork!");

            Commands command = Commands.UNKNOWN;
            while (command != Commands.QUIT)
            {
                Console.Write($"{Location}\n> ");
                command = ToCommand(Console.ReadLine().Trim());

                string outputString;
                switch(command)
                {
                    case Commands.QUIT:
                        outputString = ("Thanks for playing!");
                        break;

                    case Commands.LOOK:
                        outputString = ("This is an open field west of a white house, with a boarded front door.\nA rubber mat saying 'Welcome to zork!' lies by the door.");
                        break;

                    case Commands.NORTH:
                    case Commands.SOUTH:
                    case Commands.EAST:
                    case Commands.WEST:
                        if (Move(command))
                        {
                            outputString = $"You moved {command}.";
                        }
                        else
                        {
                            outputString = ("The way is shut!");
                        }
                        break;

                    default:
                        command = Commands.UNKNOWN;
                        outputString = ("Unknown Command.");
                        break;
                };

                Console.WriteLine(outputString);
            }
        }

        private static bool Move(Commands command)
        {
            bool didMove = false;

            switch (command)
            {
                case Commands.NORTH:
                    break;
                case Commands.SOUTH:
                    break;
                case Commands.EAST when LocationColumn <Rooms.Length -1:
                        LocationColumn += 1;
                        didMove = true;
                    break;
                case Commands.WEST when LocationColumn > 0:
                        LocationColumn -= 1;
                        didMove = true;
                    break;
            }
            return didMove;
        }
        private static Commands ToCommand(string commandString) => (Enum.TryParse<Commands>(commandString, true, out Commands result) ? result : Commands.UNKNOWN);


        private static string[] Rooms = { "Forest", "West of House", "Behind House", "Clearing", "Canyon View"};
        private static int LocationColumn = 1;
    }
}
