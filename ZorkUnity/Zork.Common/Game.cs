using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Zork
{
    public class Game : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public World World { get; private set; }

        public string StartingLocation { get; set; }
        
        public string WelcomeMessage { get; set; }
        
        public string ExitMessage { get; set; }
        [JsonIgnore]
        public int Moves = 0;
        [JsonIgnore]
        public Player Player { get; private set; }
        [JsonIgnore]
        public static Game Instance { get; private set; }
        [JsonIgnore]
        public IOutputService Output { get; set; }
        [JsonIgnore]
        public IInputService Input { get; set; }

        public bool IsRunning { get; set; }

        [JsonIgnore]
        public Dictionary<string, Command> Commands { get; private set; }
        public static Player SpawnPlayer { get; private set; }

        public Game(World world, Player player)
        {
            World = world;
            Player = player;

            Commands = new Dictionary<string, Command>()
            {
                { "QUIT", new Command("QUIT", new string[] { "QUIT", "Q", "BYE" }, Quit) },
                { "LOOK", new Command("LOOK", new string[] { "LOOK", "L" }, Look) },
                { "NORTH", new Command("NORTH", new string[] { "NORTH", "N" }, game => Move(game, Directions.North)) },
                { "SOUTH", new Command("SOUTH", new string[] { "SOUTH", "S" }, game => Move(game, Directions.South)) },
                { "EAST", new Command("EAST", new string[] { "EAST", "E"}, game => Move(game, Directions.East)) },
                { "WEST", new Command("WEST", new string[] { "WEST", "W" }, game => Move(game, Directions.West)) },
            };
        }
        public static void StartFromFile(string gameFileName, IInputService input, IOutputService output)
        {
            Start(File.ReadAllText(gameFileName), input, output);
        }
        public static void Start(string gameJsonString, IInputService input, IOutputService output)
        {
            
            Instance = Load(gameJsonString);
            Instance.Input = input;
            Instance.Output = output;
            Instance.DisplayWelcomeMessage();
            Instance.IsRunning = true;
            Instance.Input.InputRecieved += Instance.InputReceivedHandler;
        }

        private void InputReceivedHandler(object sender, string inputString)
        {

            Room previousRoom = null;
            string commandString = inputString;
                Command foundCommand = null;
                foreach (Command command in Commands.Values)
                {
                    if (command.Verbs.Contains(commandString))
                    {
                        foundCommand = command;
                    Moves++;
                    break;
                    }
                }

                if (foundCommand != null)
                {
                                    
                    foundCommand.Action(this);
                    Game.Instance.Output.WriteLine(Game.Instance.Player.Location);
                    if (previousRoom != Player.Location)
                            {
                                Look(this);
                                previousRoom = Player.Location;
                            }
                }
                else
                {
                    Output.WriteLine("Unknown command.");
                }
            
        }

        public static Game Load(string jsonString)
        {
            Game game = JsonConvert.DeserializeObject<Game>(jsonString);
            game.Player = SpawnPlayer;

            return game;
        }

        private static void Move(Game game, Directions direction)
        {
            if (game.Player.Move(direction) == false)
            {
                Instance.Output.WriteLine("The way is shut!");
            }
        }

        public static void Look(Game game) => Instance.Output.WriteLine(game.Player.Location.Description);

        private void Quit(Game game)
        {
            DisplayExitMessage();
            game.IsRunning = false;
        }
        private void DisplayWelcomeMessage()
        {
            Output.WriteLine(WelcomeMessage);
        }
        private void DisplayExitMessage()
        {
            Output.WriteLine(ExitMessage);
        }

        [OnDeserialized]
        private void OnDeserialized(StreamingContext context) => SpawnPlayer = new Player(World, StartingLocation);
    }
}