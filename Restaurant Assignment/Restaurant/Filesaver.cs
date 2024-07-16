using Restaurant.Contract;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant
{
    public class Filesaver : ISaver
    {
        public bool exportBill(List<IItemExtended> billDetails,int billprice)
        {
            File.WriteAllText("bill.txt", "Your Final Bill : \n\n");
            foreach (var bill in billDetails)
            {
                File.AppendAllText("bill.txt", bill.name + " : Rs." + bill.price +"\n");
            }
            File.AppendAllText("bill.txt", "\n------------------ \nTotal Price : " + billprice);

            Console.WriteLine("Bill Generated Successfully \n\n Thank you for ordering");
            return true;
        }
    }
}
