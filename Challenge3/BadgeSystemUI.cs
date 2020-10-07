using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Challenge3
{
    class BadgeSystemUI
    {
        public void Run()
        {
            BadgeRepository badgeRepo = new BadgeRepository();

            Badge badge1 = new Badge(10000, new List<string>() { "A1", "A2", "B1" });
            Badge badge2 = new Badge(20000, new List<string>() { "A1", "A2"});
            Badge badge3 = new Badge(30000, new List<string>() { "B1", "B2" });


            badgeRepo.AddBadge(badge1);
            badgeRepo.AddBadge(badge2);
            badgeRepo.AddBadge(badge3);

            bool isOver = false;

            while (!isOver)
            {

                Console.Clear();
                Console.WriteLine("Hello and welcome to Komodo Insurance Badge System!");
                Console.WriteLine("");
                Console.WriteLine("Please select an option: ");
                Console.WriteLine("1: Add a badge.");
                Console.WriteLine("2: Edit a badge.");
                Console.WriteLine("3: List all badges.");
                Console.WriteLine("4: Exit.");


                string answer = Console.ReadLine();

                switch (answer)
                {
                    //Add a badge
                    case "1":
                        {
                            Console.Clear();
                            Console.WriteLine("You have chosen to add a badge.");
                            Console.WriteLine("Enter the badge ID number to add: ");
                            string idAnswer = Console.ReadLine();
                            int idToInt = Int32.Parse(idAnswer);
                            Badge badgeToAdd = new Badge(idToInt);

                            bool doorsAdded = false;

                            while (!doorsAdded)
                            {

                                Console.WriteLine("List a door this badge needs access to: ");
                                string doorToAdd = Console.ReadLine();
                                badgeToAdd.AddDoorToBadge(doorToAdd);

                                Console.WriteLine("Any other doors to add? (y/n): ");
                                string moreDoors = Console.ReadLine();
                                if (moreDoors == "n")
                                {
                                    doorsAdded = true;
                                }
                                else
                                {
                                    doorsAdded = false;
                                }
                            }

                            badgeRepo.AddBadge(badgeToAdd);

                            break;
                        }
                    //Edit a badge
                    case "2":
                        {
                            Console.Clear();

                            Console.WriteLine("You have chosen to edit a current badge.");
                            Console.WriteLine("Enter the badge ID number: ");

                            string idAnswer = Console.ReadLine();
                            int idToInt = Int32.Parse(idAnswer);
                            Badge badgeToEdit = badgeRepo.FindBadgeByNumber(idToInt);

                            if(badgeToEdit != null)
                            {
                                bool goBack = false;

                                while (!goBack)
                                {
                                    Console.Clear();
                                    badgeRepo.ReadBadge(badgeToEdit);
                                    Console.WriteLine("What would you like to do?: ");
                                    Console.WriteLine("1. Remove a door");
                                    Console.WriteLine("2. Add a door");
                                    Console.WriteLine("3. Return to main menu");

                                    string doorChoice = Console.ReadLine();

                                    switch (doorChoice)
                                    {
                                        //Remove door from badge
                                        case "1":
                                            {
                                                Console.WriteLine("Enter the door to remove: ");
                                                string doorToRemove = Console.ReadLine();
                                                if (badgeToEdit.ReturnDoorList().Contains(doorToRemove))
                                                {
                                                    badgeRepo.RemoveDoorFromBadge(badgeToEdit, doorToRemove);
                                                }
                                                else
                                                {
                                                    Console.WriteLine("No such door found.");
                                                }

                                                Console.WriteLine("Press any key to continue...");
                                                Console.ReadLine();

                                                break;
                                            }
                                        //add door to badge
                                        case "2":
                                            {
                                                Console.WriteLine("Enter the door to add: ");
                                                string doorToAdd = Console.ReadLine();
                                                badgeToEdit.AddDoorToBadge(doorToAdd);

                                                Console.WriteLine("Press any key to continue...");
                                                Console.ReadLine();

                                                break;
                                            }
                                        //return to menu
                                        case "3":
                                            {
                                                goBack = true;
                                                break;
                                            }

                                        default: break;

                                    }



                                }

                            }
                            else
                            {
                                Console.WriteLine("No such badge found!");
                            }

                            break;
                        }
                    //List All badges
                    case "3":
                        {
                            badgeRepo.ReadAllBadges();
                            break;
                        }
                    case "4":
                        {
                            isOver = true;
                            break;
                        }

                    default:
                        {
                            break;
                        }

                }

                Console.WriteLine("Press any key to continue...");
                Console.ReadLine();


            }


        }
    }
}
