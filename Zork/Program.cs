using System;
using System.Collections.Generic;
using System.IO;

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
            Room previousRoom = null;

            const string roomDescriptionsFilename = "Rooms.txt";
            InitializedRoomDescriptions(roomDescriptionsFilename);

            Commands command = Commands.UNKNOWN;
            while (command != Commands.QUIT)
            {
                Console.Write($"{CurrentRoom.ToString()}\n");
                if (previousRoom != CurrentRoom)
                {
                    Console.Write($"{ CurrentRoom.Description}\n>");
                    previousRoom = CurrentRoom;
                }
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

        private static void InitializedRoomDescriptions(string roomDescriptionsFilename)
        {
            var roomMap = new Dictionary<string, Room>();
            foreach (Room room in Rooms)
            {
                roomMap.Add(room.Name, room);
            }

            string[] lines = File.ReadAllLines(roomDescriptionsFilename);
            foreach (string line in lines)
            {
                const string delimiter = "##";
                const int expectedFieldCount = 2;

                string[] fields = line.Split(delimiter);
                if (fields.Length != expectedFieldCount)
                {
                    continue;
                }
                (string name, string description) = (fields[(int)Fields.Name], fields[(int)Fields.Description]);
                roomMap[name].Description = description;
            }

        }
        private static readonly Room[,] Rooms = { 
                                                    {new Room ("Rocky Trail"), new Room ("South of House"), new Room ("Canyon View") },
                                                    {new Room ("Forest"), new Room ("West of House"), new Room ("Behind House")},
                                                    {new Room ("Dense Woods"), new Room ("North of House"), new Room ("Clearing") }
                                                    };
        private static int LocationColumn = 1;
        private static int LocationRow = 1;

        private enum Fields
        {
            Name = 0,
            Description = 1
        }
    }
}
