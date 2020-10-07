using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge2
{
    class ClaimsSystemUI
    {
        public void Run()
        {
            ClaimsRepository claimsRepo = new ClaimsRepository();

            DateTime day1 = new DateTime(2020, 8, 23);
            DateTime day2 = new DateTime(2020, 9, 5);

            DateTime day3 = new DateTime(2010, 5, 4);
            DateTime day4 = new DateTime(2011, 7, 11);

            DateTime day5 = new DateTime(2020, 9, 25);
            DateTime day6 = new DateTime(2020, 10, 04);

            Claim claim1 = new Claim(1, (Claim.TypeOfClaim) 1, "Car flipped into ditch after icy turn.", 2000.00, day1, day2);
            Claim claim2 = new Claim(2, (Claim.TypeOfClaim) 2,"House caught on fire.", 50000.00, day3, day4);
            Claim claim3 = new Claim(3, (Claim.TypeOfClaim) 3, "Robbed at gunpoint in the street for phone and wallet.", 1000.00, day5, day6);

            claimsRepo.AddClaim(claim1);
            claimsRepo.AddClaim(claim2);
            claimsRepo.AddClaim(claim3);

            bool isOver = false;

            while (!isOver)
            {

                Console.Clear();
                Console.WriteLine("Hello and welcome to Komodo Claims!");
                Console.WriteLine("");
                Console.WriteLine("Please select an option: ");
                Console.WriteLine("1: See all claims.");
                Console.WriteLine("2: Take care of next claim.");
                Console.WriteLine("3: Enter a new claim.");
                Console.WriteLine("4: Exit.");


                string answer = Console.ReadLine();

                switch (answer)
                {
                    //read all items
                    case "1":
                        {
                            Console.Clear();
                            Console.WriteLine("Reading all claims: ");
                            claimsRepo.ReadAllClaims();
                            Console.WriteLine("");
                            break;
                        }
                    //take care of next claim
                    case "2":
                        {
                            Console.Clear();

                            if (claimsRepo.ReadNextFromQueue() != null) {
                                Console.WriteLine("The next claim in the queue: ");

                                claimsRepo.ReadClaim(claimsRepo.ReadNextFromQueue());
                                Console.WriteLine("");
                                Console.WriteLine("Do you want to deal with this claim now? (y/n): ");
                                string dealAnswer = Console.ReadLine();
                                if (dealAnswer == "y")
                                {
                                    Console.WriteLine("Popping FROM QUEUE (claim still in repo though!)...");
                                    claimsRepo.PopNextFromQueue();
                                }

                            }

                            else
                            {
                                Console.WriteLine("No claims currently in the queue!");
                            }

                            break;
                        }
                    //add a new claim
                    case "3":
                        {
                            Console.Clear();
                            Console.WriteLine("You have chosen to add a new claim.");
                            Console.WriteLine("Please enter the Claim ID number: ");
                            string idAnswer = Console.ReadLine();
                            int idToInt = int.Parse(idAnswer);
                            Console.WriteLine("Please enter the Type of this claim (1 = Car, 2 = Home, 3 = Theft): ");
                            string typeAnswer = Console.ReadLine();
                            int typeToInt = int.Parse(typeAnswer);
                            Console.WriteLine("Please enter the description of this claim: ");
                            string descAnswer = Console.ReadLine();
                            Console.WriteLine("Please enter the amount of this claim: ");
                            string amountAnswer = Console.ReadLine();
                            double amountToDouble = Convert.ToDouble(amountAnswer);
                            Console.WriteLine("Please enter the date of the incident (yyyy/mm/dd): ");
                            Console.WriteLine("First, enter the year (XXXX): ");
                            string yearOfInc = Console.ReadLine();
                            int YOIToInt = Int32.Parse(yearOfInc);
                            Console.WriteLine("Second, enter the month (X or XX): ");
                            string monthOfInc = Console.ReadLine();
                            int MOIToInt = Int32.Parse(monthOfInc);
                            Console.WriteLine("Third, enter the day (X or XX): ");
                            string dayOfInc = Console.ReadLine();
                            int DOIToInt = Int32.Parse(dayOfInc);
                            DateTime dateOfInc = new DateTime(YOIToInt, MOIToInt, DOIToInt);
                            Console.WriteLine("Please enter the date of this claim (yyyy/mm/dd): ");
                            Console.WriteLine("First, enter the year (XXXX): ");
                            string yearOfClaim = Console.ReadLine();
                            int YOCToInt = Int32.Parse(yearOfClaim);
                            Console.WriteLine("Second, enter the month (X or XX): ");
                            string monthOfClaim = Console.ReadLine();
                            int MOCToInt = Int32.Parse(monthOfClaim);
                            Console.WriteLine("Third, enter the day (X or XX): ");
                            string dayOfClaim = Console.ReadLine();
                            int DOCToInt = Int32.Parse(dayOfClaim);
                            DateTime dateOfClaim = new DateTime(YOIToInt, MOIToInt, DOIToInt);

                            Claim claim = new Claim(idToInt, (Claim.TypeOfClaim)typeToInt, descAnswer, amountToDouble, dateOfInc, dateOfClaim);

                            claimsRepo.AddClaim(claim);


                            Console.WriteLine("");
                            Console.WriteLine("Claim added.");


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
