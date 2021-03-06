using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.ComponentModel;

namespace Zork
{
     public class World : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        
        public List<Room>Rooms { get; set; }

        [JsonIgnore]
        public Dictionary<string, Room> RoomsByName => mRoomsByName;

        public Player SpawnPlayer() => new Player(this, StartingLocation);

        [OnDeserialized]
        private void OnDeserialized(StreamingContext context)
        {
            mRoomsByName = Rooms.ToDictionary(room => room.Name, room => room);

            foreach (Room room in Rooms)
            {
                room.UpdateNeighbors(this);
            }
        }

        [JsonProperty]
        public string StartingLocation { get; set; }

        private Dictionary<string, Room> mRoomsByName;


        public World()
        {
            Rooms = new List<Room>();
        }
    }
}
