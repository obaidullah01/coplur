using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<int>> studentDict = new Dictionary<string, List<int>>();
            studentDict.Add("Obaid", AddList("Obaid"));
            studentDict.Add("Steve", AddList("Steve"));
            studentDict.Add("Thor", AddList("Thor"));

            printData(studentDict);

            Dictionary<string,int> average = findAverage(studentDict);
            printlist(average);

            string highestAvgName = findHighAverage(average);
            Console.WriteLine(highestAvgName + " has the Highest Average of : " + average[highestAvgName]);

            Console.ReadLine();
        }

        public static string findHighAverage(Dictionary<string, int> average)
        {
            var sortedAvg = from avg in average orderby avg.Value descending select avg;

            var first = sortedAvg.First();
            return first.Key;
        }


        public static void printlist(Dictionary<string, int> average)
        {
            Console.WriteLine("\nThe average of the students are : ");

            foreach (var student in average)
            {
                    Console.WriteLine(student.Key + " : " + student.Value);
                
            }
            Console.WriteLine();
        }

        public static Dictionary<string, int> findAverage(Dictionary<string, List<int>> studentDict)
        {
            Dictionary<string,int> average = new Dictionary<string,int>();

            
            foreach (var student in studentDict)
            {
                int sum = 0;
                int count = 0;
                foreach (int marks in student.Value)
                {
                    sum += marks;
                    count++;
                }
                int  avg = (sum/count);
                average.Add(student.Key , avg);
                
            }
            return average;
            

        }

        public static void printData(Dictionary<string, List<int>> studentDict)
        {
            foreach (var student in studentDict)
            {
                Console.WriteLine("\nThe marks of " + student.Key +" are : ");
                foreach (var key in student.Value)
                {
                    Console.Write(key + " ");
                }
                Console.WriteLine();
            }

        }

        public static List<int> AddList(string Sname)
        {
            List<int> temp = new List<int>();
            int i = 1;
            Console.WriteLine("Please Enter the marks of " + Sname + " : ");
            while (i <= 3)
            {
                Console.WriteLine("Enter Marks of " + i + " subject : ");
                temp.Add(Convert.ToInt32(Console.ReadLine()));
                i++;
            }
            Console.WriteLine();
            return temp;
        }
    }
}
