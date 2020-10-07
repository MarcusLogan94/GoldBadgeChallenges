using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Challenge1
{
    class CafeUI
    {
        public void Run()

        {

            MenuRepository menu = new MenuRepository();

            MenuItem Roast = new MenuItem(1, "Beef Roast", "A delectable roast of beef with carrots and potatoes.", "beef, carrots, potatoes", 12.00);
            MenuItem PeaSoup = new MenuItem(2, "Pea Soup", "An inviting soup of peas with cream and spices.", "peas, cream, spices", 6.50);
            MenuItem Lasagna = new MenuItem(3, "Lasagna", "A classic dish of lasagna, just the way you like it.", "flat noodles, red sauce, cheese, ground beef", 10.50);

            menu.AddItem(Roast);
            menu.AddItem(PeaSoup);
            menu.AddItem(Lasagna);

            bool isOver = false;

            while (!isOver)
            {
                Console.Clear();
                Console.WriteLine("Hello and welcome to Komodo Cafe!");
                Console.WriteLine("");
                Console.WriteLine("Please select an option: ");
                Console.WriteLine("1: Add an item.");
                Console.WriteLine("2: Delete an item.");
                Console.WriteLine("3: View all items.");
                Console.WriteLine("4: Exit.");

                string answer = Console.ReadLine();

                switch(answer){

                    //add item
                    case "1":
                        {
                            Console.Clear();
                            Console.WriteLine("You have chosen to add an item.");
                            Console.WriteLine("Please enter the Meal Number of this item. Be careful of conflicts, 1-3 are taken: ");
                            string numAnswer = Console.ReadLine();
                            int numToInt = int.Parse(numAnswer);
                            Console.WriteLine("Please enter the name of this meal: ");
                            string nameAnswer = Console.ReadLine();
                            Console.WriteLine("Please enter the description of this meal: ");
                            string descAnswer = Console.ReadLine();
                            Console.WriteLine("Please enter the ingredients of this meal: ");
                            string ingrAnswer = Console.ReadLine();
                            Console.WriteLine("Please enter the price of this meal (expecting X.XX or XX.XX format): ");
                            string priceAnswer = Console.ReadLine();
                            double priceToDouble = Convert.ToDouble(priceAnswer);

                            MenuItem newItem = new MenuItem(numToInt, nameAnswer, descAnswer, ingrAnswer, priceToDouble);

                            menu.AddItem(newItem);
                            Console.WriteLine("");
                            Console.WriteLine("Item added.");
                            

                            break;
                        }
                    //delete item
                    case "2":
                        {
                            Console.WriteLine("You have chosen to remove an item from the menu.");
                            Console.WriteLine("Please enter the meal number of the item you wish to remove: ");
                            string removeAnswer = Console.ReadLine();
                            int removeToInt = Int32.Parse(removeAnswer);

                            MenuItem item = menu.FindItemByNumber(removeToInt);

                            menu.DeleteItem(item);

                            Console.WriteLine("");
                            Console.WriteLine("Item removed.");
                            

                            break;
                        }
                    //read all items
                    case "3":
                        {
                            menu.ReadAllItems();
                            Console.WriteLine("");
                            
                            break;
                        }
                    //exit
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
