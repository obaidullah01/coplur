using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<string> Fruitlist = new List<string>();

            AddFruit("Guava", Fruitlist);           //Adding Fruit to the list
            AddFruit("Mango", Fruitlist);           
            AddFruit("Apple", Fruitlist);           
            AddFruit("Orange", Fruitlist);
            AddFruit("Banana", Fruitlist);
            AddFruit("Grapes", Fruitlist);


            Fruitlist.Remove("Orange");             //Removing Fruit from the list 
            showFruitList(Fruitlist);

            RemoveFruit("Mango", Fruitlist);
            showFruitList(Fruitlist);

            Fruitlist.Remove(Fruitlist[3]);
            showFruitList(Fruitlist);

            Console.WriteLine(Fruitlist[0]);         //Accessing Fruit(Items) from the list
            Console.WriteLine(Fruitlist[2]);

            checkList("Apple", Fruitlist);          //Checking whether the fruit exist in the list or not


            Console.ReadLine();

        }

        public static void checkList(string fruit, List<string> fruitlist)
        {
            if(fruitlist.Contains(fruit)) Console.WriteLine(fruit + " exist");
            else Console.WriteLine(fruit + " does not exist");
        }

        public static void RemoveFruit(string fruit, List<string> fruitlist)
        {
            fruitlist.Remove(fruit);
            Console.WriteLine(fruit + " removed");
            Console.WriteLine();
        }

        public static void AddFruit(string fruit, List<string> fruitlist)
        {
            fruitlist.Add(fruit);
            Console.WriteLine("New Fruit Added : " + fruit +"\n");
        }

        public static void showFruitList(List<string> fruitlist)
        {
            Console.WriteLine("Displaying the List : ");
            foreach (var fruit in fruitlist) {
                Console.WriteLine(fruit);
            }
            Console.WriteLine();
        }
    }
}
