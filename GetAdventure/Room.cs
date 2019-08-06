using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetAdventure
{
    class Room
    {
        public char Name { get; private set; }
        private List<Door> _doors;

        public Room(char name)
        {
            Name = name;
            _doors = new List<Door>();
        }

        public void AddDoor(Door door)
        {
            _doors.Add(door);
        }

        //private char _name;

        //public char Name
        //{
        //    get
        //    {
        //        return _name;
        //    }
        //    private set
        //    {
        //        _name = value;
        //    }
        //}

        //public char GetName()
        //{
        //    return _name;
        //}

        //private void SetName(char newName)
        //{
        //    _name = newName;
        //}
        public Room GetRoom(char newRoomName)
        {
            foreach (var door in _doors)
            {
                var room = door.GetRoom(newRoomName);
                if (room != null)
                {
                    return room;
                }
            }
            return null;
        }
    }
}
