using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Int32> numlist = new List<Int32>() { 45, 37, 97, 54, 51, 12, 2, 11 };
            printList(numlist);
            //numlist.Sort();                       //Sorting using pre-define Sort method
            //printList(numlist);


            numlist = quicksortList(numlist,0,(numlist.Capacity -1));
            printList(numlist);

            searchKey(numlist,97);              //Linear search
            bsearchKey(numlist,51, 0, (numlist.Capacity - 1));          //Binary search
            Console.ReadLine();

        }

        private static void bsearchKey(List<int> numlist, int key, int low, int high)
        {
            if (low > high)
            {
                Console.WriteLine("Number not found");
                return;
            }
            int mid = (low + high) / 2;
            if (numlist[mid] == key)
            {
                Console.WriteLine("Number found at " + mid + " Index");
                return;
            }
            else if (numlist[mid] < key) bsearchKey(numlist, key, mid+1, high);
            else if (numlist[mid] > key) bsearchKey(numlist, key, low, mid-1);
        }

        public static void searchKey(List<int> numlist, int key)
        {
            for(int num =0; num<(numlist.Capacity); num++)
            {
                if (numlist[num] == key)
                {
                    Console.WriteLine("Number found at " + num+" index"); 
                    return;

                }
            }
            Console.WriteLine("Number not found");
        }

        public static List<Int32> quicksortList(List<int> numlist,int fwdindex, int bckindex)
        {
            int i = fwdindex;
            int j = bckindex;
            int pivot = numlist[fwdindex];

            while (i <= j)
            {
                while(pivot > numlist[i])
                {
                    i++;
                }
                while(pivot < numlist[j])
                {
                    j--;
                }

                if (i <= j)
                {
                    int temp = numlist[i];
                    numlist[i] = numlist[j];
                    numlist[j] = temp;
                    i++;
                    j--;
                }
            }


            if (i < bckindex) quicksortList(numlist,i,bckindex);
            if (j > fwdindex) quicksortList(numlist,fwdindex,j);

            return numlist;
        }

        public static void printList(List<int> numlist)
        {
            Console.WriteLine("The numbers in the list are : ");
            foreach (int num in numlist)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
        }
    }
}
