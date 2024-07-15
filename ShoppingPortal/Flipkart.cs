using ShoppingPortal.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingPortal
{
    public class Flipkart : IShop
    {
        public void successCode()
        {
            Console.WriteLine("Ordered From Flipkart");
        }
    }
}
