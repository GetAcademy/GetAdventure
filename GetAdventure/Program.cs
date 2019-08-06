using System;
using System.Linq;

namespace GetAdventure
{
    class Program
    {

        static void Main(string[] args)
        {
            var a = new Room('A');
            var b = new Room('B');
            var c = new Room('C');
            var d = new Room('D');
            var e = new Room('E');
            var f = new Room('F');

            var rooms = new[] { a, b, c, d, e, f };
            var currentRoom = a;

            var doors = new[]
            {
                new Door(a, d),
                new Door(a, b),
                new Door(b, e),
                new Door(b, c),
                new Door(e, f )
            };

            while (true)
            {
                Console.WriteLine("Du er i rom " + currentRoom.Name);
                Console.Write("Hvor vil du gå? ");
                var newRoomName = Console.ReadLine().ToUpper()[0];
                var room = currentRoom.GetRoom(newRoomName);
                if (room!=null)
                {
                    currentRoom = room;
                }
            }
        }
    }


    //    static void Main(string[] args)
    //    {
    //        char _currentRoom = 'A';
    //        string _rooms = "ABCDEF";
    //        string[] _doors = new[]
    //        {
    //            "AD",
    //            "AB",
    //            "BE",
    //            "BC",
    //            "EF"
    //        };

    //        while (true)
    //        {
    //            Console.WriteLine("Du er i rom " + _currentRoom);
    //            Console.Write("Hvor vil du gå? ");
    //            var newRoom = Console.ReadLine().ToUpper()[0];
    //            if (_rooms.Contains(newRoom)) // Rommet finnes
    //            {
    //                // Finnes døren?
    //                var doorCode1 = "" + _currentRoom + newRoom;
    //                var doorCode2 = "" + newRoom + _currentRoom;
    //                if (Array.IndexOf(_doors, doorCode1) != -1
    //                    || Array.IndexOf(_doors, doorCode2) != -1)
    //                {
    //                    _currentRoom = newRoom;
    //                }
    //            }

    //        }
    //    }
    //}
}
