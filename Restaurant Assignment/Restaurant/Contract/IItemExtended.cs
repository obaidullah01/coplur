using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Contract
{
    public interface IItemExtended :IItem
    {
      string name { get; set; }
        int price { get; set; }
    }
}
