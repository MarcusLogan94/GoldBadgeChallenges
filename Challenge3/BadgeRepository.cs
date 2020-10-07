using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Challenge3
{
    class BadgeRepository
    {

        public List<Badge> badgeRepository = new List<Badge>();

        public void AddBadge(Badge badge)
        {
            badgeRepository.Add(badge);
        }

        public void RemoveBadge(Badge badge)
        {
            badgeRepository.Remove(badge);

        }

        public void AddDoorToBadge(Badge badge, string door)
        {
            badge.AddDoorToBadge(door);
        }

        public void RemoveDoorFromBadge(Badge badge, string door)
        {
            badge.RemoveDoorFromBadge(door);
        }

        public void RemoveAllFromBadge(Badge badge)
        {
            badge.RemoveAllDoorsFromBadge();
        }

        public Badge FindBadgeByNumber(int n)
        {

            for (int i = 0; i < badgeRepository.Count; i++)
            {
                if (badgeRepository[i].BadgeID == n)
                {
                    return badgeRepository[i];
                }
            }

            return null;

        }

        public void ReadBadge(Badge badge)
        {
            Console.WriteLine("Badge ID Number: " + badge.BadgeID);
            Console.Write("Doors this badge has access to:");
            for (int i = 0; i < badge.ReturnDoorList().Count; i++)
            {
                //if last element and also not first element
                if( (i == (badge.ReturnDoorList().Count - 1)) && (i != 0) ){
                    Console.Write(" and " + badge.ReturnDoorList()[i]);
                }
                else
                {
                    Console.Write(" " + badge.ReturnDoorList()[i]);
                }
                
            }
            Console.WriteLine("");
            
        }              

        public void ReadAllBadges()
        {
            int count = badgeRepository.Count();

            for (int i = 0; i < count; i++)
            {
                Console.WriteLine("-------------------------------------------------------------");
                ReadBadge(badgeRepository[i]);
                Console.WriteLine("");
            }

        }


    }
}
