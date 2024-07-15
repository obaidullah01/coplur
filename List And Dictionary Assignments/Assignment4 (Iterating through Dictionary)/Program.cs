using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string,double> productDict = new Dictionary<string,double>();
            AddProduct(productDict, "Pen", 10);
            AddProduct(productDict, "Erasor", 5);
            AddProduct(productDict, "Copy", 45);
            AddProduct(productDict, "Book", 150);
            AddProduct(productDict, "Box", 250);

            printData(productDict);

            double average = findAverage(productDict);

            Console.WriteLine("The average is : " + average);

            string expensive = findExpensive(productDict);
            Console.WriteLine("The Expensive Item is " + expensive + " With Rs." + productDict[expensive]);

            Console.ReadLine();
        }

        public static string findExpensive(Dictionary<string, double> productDict)
        {
            var sortedDic = from product in productDict orderby product.Value descending select product;

            var first = sortedDic.First();
            return first.Key;

        }

        private static double findAverage(Dictionary<string, double> productDict)
        {
            double sum = 0;
            int count = 0;
            foreach(var key in productDict)
            {
                sum +=key.Value;
                count++;
            }
            return (double)sum / count;
        }

        public static void printData(Dictionary<string, double> productDict)
        {
            Console.WriteLine("\nThe Product with their price are \n");
            foreach (var data in productDict)
            {
                Console.WriteLine(data.Key + " : Rs." +data.Value );
            }

            Console.WriteLine();
        }

        public static void AddProduct(Dictionary<string,double> productDict, string product, double price)
        {
            productDict.Add(product, price);
            Console.WriteLine(price + " is added to dictionary with its key " + product);
        }
    }
}
