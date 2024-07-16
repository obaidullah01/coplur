using Restaurant.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant
{
    public class FoodItem : IItemExtended
    {
        static List<IItemExtended> foodlist = new List<IItemExtended>();

        public string name { get; set; }
        public int price { get; set; }




        public bool addItem()
        {
            FoodItem foodl = new FoodItem();
            Console.WriteLine("Enter the name of the Food you wanted to add : ");
            foodl.name = Console.ReadLine();
            Console.WriteLine("Enter the price you wanted to set : ");
            foodl.price = Convert.ToInt32(Console.ReadLine());

            foodlist.Add(foodl);

            return true;

        }

        public bool removeItem()
        {
            if(foodlist.Count == 0)
            {
                Console.WriteLine("Sorry there's no Food available right now !");
                return false;
            }
            Console.WriteLine("Enter the food name you wanted to delete : ");
            string fname = Console.ReadLine();
            foreach (var item in foodlist)
            {
                if (item.name.Contains(fname))
                {
                    foodlist.Remove(item);
                    Console.WriteLine("Food removed Successfully !");
                    return true;
                }
            }
            Console.WriteLine("Food not found !");

            return false;
        }
        public static List<IItemExtended> getlist()
        {
            return foodlist;
        }


    }
}
