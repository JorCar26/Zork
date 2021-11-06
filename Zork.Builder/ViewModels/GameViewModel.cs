using System;
using System.ComponentModel;
using System.IO;
using Newtonsoft.Json;
using System.Runtime.CompilerServices;

namespace Zork.Builder.ViewModels
{
    public class GameViewModel : INotifyPropertyChanged
    {

        public event PropertyChangedEventHandler PropertyChanged;

        public string FileName { get; set; }

        public BindingList<Room> Rooms { get; set; }
        public Game Game
        {
            get => game;
            set
            {
                if (game != value)
                {
                    game = value;
                    if (game != null)
                    {
                        Rooms = new BindingList<Room>(game.World.Rooms);
                    }
                    else
                    {
                        Rooms = new BindingList<Room>(Array.Empty<Room>());
                    }
                }
            }
        }


        public void SaveGame()
        {
            if (string.IsNullOrEmpty(FileName))
            {
                throw new InvalidProgramException("Filename expected");
            }

            JsonSerializer serializer = new JsonSerializer
            {
                Formatting = Formatting.Indented
            };
            using (StreamWriter streamWriter = new StreamWriter(FileName))
            using (JsonWriter jsonWriter = new JsonTextWriter(streamWriter))
            {
                serializer.Serialize(jsonWriter, game);
            }
        }
        private Game game;
    }
}
