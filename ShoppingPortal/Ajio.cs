using ShoppingPortal.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingPortal
{
    public class Ajio : IShop
    {
        public void successCode()
        {
            Console.WriteLine("Ordered from Ajio");
        }
    }
}
