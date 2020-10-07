using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge3
{
    class Badge
    {

        public int BadgeID { get; set; }

        List<string> DoorList = new List<string>();

        public Badge(int idNumber)
        {
            BadgeID = idNumber;
        }

        public Badge(int idNumber, List<string> list)
        {
            BadgeID = idNumber;
            DoorList = list;
        }

        public void AddDoorToBadge(string door)
        {

            DoorList.Add(door);

        }

        public void RemoveDoorFromBadge(string door)
        {
            if (DoorList.Contains(door))
            {
                DoorList.Remove(door);
            }
        }

        public void RemoveAllDoorsFromBadge()
        {
            while(DoorList.Count > 0)
            {
                DoorList.RemoveAt(0);
            }
        }

        public List<string> ReturnDoorList()
        {
            return DoorList;
        }

    }
}
