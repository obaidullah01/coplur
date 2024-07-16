using Restaurant.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant
{
    public class ItemManager
    {
        IItem _itemtype = null;
        public ItemManager(IItem itemtype) { 
            _itemtype = itemtype;
        }

        public bool addItem()
        {
            Console.WriteLine("\nHow many Items do you wanna add ? ");
            try
            {
                int itemvalue = Convert.ToInt32(Console.ReadLine());
                for (int i = 0; i < itemvalue; i++) { _itemtype.addItem(); }

                Console.WriteLine("\nItem Added successfully \n");
                return true;
            }
            catch (Exception ex) {
                Console.WriteLine("Error : " + ex.Message + "\n\nPlease Try again");
                addItem();
                Console.WriteLine();
                return false;
            }

        }

        public bool removeItem()
        {
            _itemtype.removeItem();
            Console.WriteLine();
            return true;
        }

         
    }
}
