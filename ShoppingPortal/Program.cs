using ShoppingPortal.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingPortal
{
    public class Program
    {
        public static IShop getShop()
        {
            string shop = "Ajio";

            if(shop == "Amazon")
            {
                return new Amazon();
            }
            else if(shop == "Flipkart"){
                return new Flipkart();
            }
            else
            {
                return new Ajio();
            }
        }
        static void Main(string[] args)
        {
            IShop shop = getShop();
            UserManager manager = new UserManager(shop);
            Console.ReadLine();
        }
    }
}
