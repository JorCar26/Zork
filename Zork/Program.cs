using System;

namespace Zork
{
    class Program
    {
        private static Room CurrentRoom
        {
            get
            {
                return Rooms[LocationRow, LocationColumn];
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Zork!");

            InitializedRoomDescriptions();

            Commands command = Commands.UNKNOWN;
            while (command != Commands.QUIT)
            {
                Console.Write($"{CurrentRoom.Name}\n> ");
                command = ToCommand(Console.ReadLine().Trim());

                string outputString;
                switch (command)
                {
                    case Commands.QUIT:
                        outputString = "Thanks for playing!";
                        break;

                    case Commands.LOOK:
                        outputString = (CurrentRoom.Description);
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
                            outputString = "The way is shut!";
                        }
                        break;

                    default:
                        command = Commands.UNKNOWN;
                        outputString = "Unknown Command.";
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
                case Commands.NORTH when LocationRow < Rooms.GetLength(0) - 1:
                    LocationRow += 1;
                    didMove = true;
                    break;
                case Commands.SOUTH when LocationRow > 0:
                    LocationRow -= 1;
                    didMove = true;
                    break;
                case Commands.EAST when LocationColumn < Rooms.GetLength(1) - 1:
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

        private static void InitializedRoomDescriptions()
        {
            Rooms[0, 0].Description = "You are on a rock-strewn trail";
            Rooms[0, 1].Description = "You are facing the south side of a white house. There is no door here, and all the windows are barred.";
            Rooms[0, 2].Description = "You are at the top of the Great Canyon on its south wall.";

            Rooms[1, 0].Description = "This is a forest, with trees in all directions around you.";
            Rooms[1, 1].Description = "This is an open field west of a white house, with a boarded front door.";
            Rooms[1, 2].Description = "You are behind the white house. In one corner of the house there is a small window which is slightly ajar.";

            Rooms[2, 0].Description = "This is a dimly lit forest, with large tress all around. To the east, there appears to be sunlight.";
            Rooms[2, 1].Description = "You are facing the north side of a white house. There is no door here, and all the windows are barred.";
            Rooms[2, 2].Description = "You are in a clearing, with a forest surrounding you on the west and south.";
        }
        private static readonly Room[,] Rooms = { 
                                                    {new Room ("Rocky Trail"), new Room ("South of House"), new Room ("Canyon View") },
                                                    {new Room ("Forest"), new Room ("West of House"), new Room ("Behind House")},
                                                    {new Room ("Dense Woods"), new Room ("North of House"), new Room ("Clearing") }
                                                    };
        private static int LocationColumn = 1;
        private static int LocationRow = 1;
    }
}
