using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Challenge1
{
    class MenuRepository
    {

        private List<MenuItem> menuRepository = new List<MenuItem>();

        public void AddItem(MenuItem item)
        {

            menuRepository.Add(item);

        }

        public void DeleteItem(MenuItem item)
        {
            menuRepository.Remove(item);
        }

        public void ReadItem(MenuItem item)
        {

            Console.WriteLine("The Menu Number of " + item.Name + " is: " + item.Number + ".");
            Console.WriteLine("The Name of " + item.Name + " is: " + item.Name + ".");
            Console.WriteLine("The Description of " + item.Name + " is: " + item.Description);
            Console.WriteLine("The Ingredients of " + item.Name + " are: " + item.Ingredients + ".");
            Console.WriteLine("The Price of " + item.Name + " is: $" + item.Price + " dollars!");

        }

        public void ReadAllItems()
        {
            int count = menuRepository.Count();
            
            for(int i = 0; i < count; i++)
            {
                Console.WriteLine("");
                Console.WriteLine(menuRepository[i].Name + ":");
                ReadItem(menuRepository[i]);
            }

        }

        public MenuItem FindItemByNumber(int n)
        {

            for(int i = 0; i < menuRepository.Count; i++)
            {
                if(menuRepository[i].Number == n)
                {
                    return menuRepository[i];
                }
            }

            return null;

        }

    }
}
