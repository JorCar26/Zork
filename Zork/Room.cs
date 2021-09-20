using System;
using System.Collections.Generic;
using System.Text;

namespace Zork
{
    class Room
    {
        public string Name { get; }
        public string Description { get; set; }

        public Room(string name = null, string description = null)
        {
            Name = name;
            Description = description;
        }
    }
}
