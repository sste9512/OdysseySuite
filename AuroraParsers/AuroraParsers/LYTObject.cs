using System.Diagnostics;

namespace AuroraParsers.AuroraParsers
{
    public class LYTObject
    {
        readonly AuroraFile _file;
        StreamReader _reader;

        public List<Room> Rooms = new List<Room>();
        public List<DoorHook> DoorHooks = new List<DoorHook>();

        public string FileDependancy = string.Empty;

        public int TrackCount = 0;
        public int ObstacleCount = 0;
        public int RoomCount = 0;
        public int DoorHookCount = 0;


        public LYTObject(AuroraFile file)
        {
            _file = file;
            _file.IsText = true;
        }

        public void Read()
        {
            _file.Open();
            _reader = _file.GetStreamReader();

            string line = "";
            bool ReadingRooms = false;
            bool ReadingDoorHooks = false;
            while ((line = _reader.ReadLine()) != null)
            {
                line = line.Trim();
                if (line.Contains("MAXLAYOUT"))
                {

                }
                else if (line.Contains("filedependancy"))
                {
                    string[] arr = line.Split(' ');
                    FileDependancy = arr[1];
                }
                else if (line.Contains("trackcount"))
                {
                    string[] arr = line.Split(' ');
                    TrackCount = int.Parse(arr[1]);
                    ReadingRooms = false;
                    ReadingDoorHooks = false;
                }
                else if (ReadingRooms)
                {
                    //Rooms.Add(Room.FromLYT(line));
                }
                else if (line.Contains("obstaclecount"))
                {
                    string[] arr = line.Split(' ');
                    ObstacleCount = int.Parse(arr[1]);
                    ReadingRooms = false;
                    ReadingDoorHooks = false;
                }
                else if (ReadingDoorHooks)
                {

                }
                else if (line.Contains("roomcount"))
                {
                    string[] arr = line.Split(' ');
                    RoomCount = int.Parse(arr[1]);
                    ReadingRooms = true;
                    ReadingDoorHooks = false;
                }
                else if (line.Contains("doorhookcount"))
                {
                    string[] arr = line.Split(' ');
                    DoorHookCount = int.Parse(arr[1]);
                    ReadingRooms = false;
                    ReadingDoorHooks = true;
                }
                else if (line.Contains("donelayout"))
                {
                    ReadingRooms = false;
                    ReadingDoorHooks = false;
                    break;
                }

            }

            Debug.WriteLine(FileDependancy);

            _file.Close();
        }


        public class Room
        {
            /*public String model;
            public vec3 position;
            public Room(String model, vec3 position)
            {
                this.model = model;
                this.position = position;
            }

            public static Room FromLYT(String lyt)
            {

                string[] arr = lyt.Trim().Split(' ');
                Debug.WriteLine(lyt);
                return new Room(arr[0].ToLower(), new vec3(float.Parse(arr[1]), float.Parse(arr[2]), float.Parse(arr[3])));
            }*/


        }

        public class DoorHook
        {

            /*public vec3 Position;

            public static DoorHook FromLYT(String lyt)
            {
                return new DoorHook();
            }*/


        }

    }
}
