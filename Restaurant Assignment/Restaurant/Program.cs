using Restaurant.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose the option below : ");
            showOption();

           showMenu();

            Console.ReadLine();
        }

        public static void showMenu()
        {
            BillManager manager = new BillManager();
            manager.manageBill();


            
        }



        public static void secondScreen(int getoption)
        {
            if (getoption == 1)
            {
                IItem type = gettype();
                ItemManager manager = new ItemManager(type);
                manager.addItem();
                showOption();
                
            }
            else if (getoption == 2)
            {
                IItem type = gettype();
                ItemManager manager = new ItemManager(type);
                manager.removeItem();
                showOption();
            }
            


        }


        public static IItem gettype()
        {
            Console.WriteLine("\nPress 1 for Food \nPress 2 for Drink ");
            int getresponse = Convert.ToInt32(Console.ReadLine());
            if (getresponse == 1)
            {
                return new FoodItem();
            } else
            {
                return new DrinkItem();
            }
        }

        public static void showOption()
            {
                Console.WriteLine("\n1.Add Item \n2.Remove Item \n3.Order Item");
                int response = Convert.ToInt32(Console.ReadLine());

            if (response == 1 || response == 2) secondScreen(response);

            else if (response == 3) return;
            else
            {
                Console.WriteLine("Wrong Input , Please Try Again !!");
                showOption();
            }

        }
        
    }
}
