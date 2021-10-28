using System;
using System.ComponentModel;
using System.IO;
using Newtonsoft.Json;
using System.Runtime.CompilerServices;

namespace Zork.Builder.ViewModels
{
    public class WorldViewModel : INotifyPropertyChanged
    {

        public event PropertyChangedEventHandler PropertyChanged;

        public string FileName { get; set; }

        public BindingList<Room> Rooms { get; set; }

        public World World 
        { 
            set
            {
                if(mWorld != value)
                {
                    mWorld = value;
                    if(mWorld != null)
                    {
                        Rooms = new BindingList<Room>((System.Collections.Generic.IList<Room>)mWorld.Rooms);

                    }
                    else
                    {
                        Rooms = new BindingList<Room>(Array.Empty<Room>());
                    }
                }
            }
        }

        public void SaveWorld()
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
                serializer.Serialize(jsonWriter, mWorld);
            }
        }
        private World mWorld;
    }
}
