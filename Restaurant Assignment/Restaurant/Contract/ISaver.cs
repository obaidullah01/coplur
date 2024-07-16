using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Contract
{
    public interface ISaver
    {
      bool exportBill(List<IItemExtended> billDetails,int billprice);
    }
}
