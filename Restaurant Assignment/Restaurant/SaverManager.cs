using Restaurant.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant
{
    public class SaverManager
    {
        ISaver _savertype = null;

        public SaverManager(ISaver savertype) {
            _savertype = savertype;
        }

        public bool exportBill(List<IItemExtended> billDetails,int price)
        {

            return _savertype.exportBill(billDetails,price);
        }

    }
}
