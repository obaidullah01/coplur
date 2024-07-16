using Restaurant.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant
{
    public class DrinkItem : IItemExtended
    {


        static List<IItemExtended> drinklist = new List<IItemExtended>();

        public string name { get; set; }
        public int price { get; set; }



        public bool addItem()
        {
            DrinkItem drinkitem = new DrinkItem();
            Console.WriteLine("Enter the name of the drink you want to add : ");
            drinkitem.name = Console.ReadLine();
            Console.WriteLine("Enter the price of the drink : ");
            drinkitem.price = Convert.ToInt32(Console.ReadLine());

            drinklist.Add(drinkitem);

            return true;
        }

        public bool removeItem()
        {

            if(drinklist.Count == 0)
            {
                Console.WriteLine("Sorry there's no drink available right now! ");
                return false;
            }
            Console.WriteLine("Enter the drink name you wanted to delete : ");
            string fname = Console.ReadLine();
            foreach (var item in drinklist)
            {
                if (item.name.Contains(fname))
                {
                    drinklist.Remove(item);
                    Console.WriteLine("Drink removed Successfully !");
                    return true;
                }
            }
            Console.WriteLine("Drink not found !");
            return false;
        }

        public static List<IItemExtended> getlist()
        {
            return drinklist;
        }

    }
}
