using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetAdventure
{
    class Door
    {
        private Room _r1;
        private Room _r2;

        public Door(Room r1, Room r2)
        {
            _r2 = r2;
            _r1 = r1;
            _r1.AddDoor(this);
            _r2.AddDoor(this);
        }


        public Room GetRoom(char roomName)
        {
            if(_r1.Name == roomName ) return _r1;
            if(_r2.Name == roomName ) return _r2;
            return null;
        }
    }
}
