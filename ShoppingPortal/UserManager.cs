using ShoppingPortal.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingPortal
{
    public class UserManager
    {
        IShop shop = null;

        public UserManager(IShop shopname) { 
        shop = shopname;

         shop.successCode();
        }

       
    }
}
