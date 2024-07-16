using Restaurant.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant
{
    public class BillManager
    { 

        public void manageBill()
        {
            int i = 1;

           List<IItemExtended> flist = FoodItem.getlist();
           List<IItemExtended> dlist = DrinkItem.getlist();

            List<IItemExtended> combinedList = new List<IItemExtended>();
            combinedList.AddRange(dlist);
            combinedList.AddRange(flist);

            if (combinedList.Count == 0)
            {
                Console.WriteLine("There's Nothing we can offer you Right Now !");
                return;
            }
            Console.WriteLine("\nThe Menu that we Offer :  \n");
            foreach (var item in combinedList) {
                Console.WriteLine(i + ". " + item.name + " : Rs." + item.price);
                i++;
            }

            Console.WriteLine("\nHow many items you wanted to order : ");
            int itemnum  = Convert.ToInt32(Console.ReadLine());

            List<IItemExtended> billList = new List<IItemExtended>();
            int BillPrice = 0;


            for (int j = 1; j <= itemnum; j++)
            {
                Console.WriteLine("Enter the " + j + " Item number : ");
                int ordernum = Convert.ToInt32(Console.ReadLine());
                billList.Add(combinedList[ordernum-1]);
                BillPrice += combinedList[ordernum-1].price;
            }

            Console.WriteLine("\n\nPrinting Your BIll .... ");
            Console.WriteLine("\nPlease Wait...");

            ISaver savertype = GetType();
            SaverManager manager = new SaverManager(savertype);
            manager.exportBill(billList, BillPrice);

        }

        public ISaver GetType()
        {
            return new Filesaver();
        }
    }
}
