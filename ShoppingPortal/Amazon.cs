using ShoppingPortal.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingPortal
{
    public class Amazon : IShop
    {
        public void successCode()
        {
            Console.WriteLine("Ordered From Amazon !");
        }
    }
}
