using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    public class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> StudentDict = new Dictionary<string, int>();
            AddStudent(StudentDict,"Obaid",80);
            AddStudent(StudentDict,"Tony",82);
            AddStudent(StudentDict,"Steve",95);
            AddStudent(StudentDict,"Rogers",77);
            AddStudent(StudentDict,"Thor",92);

            printData(StudentDict);


            UpdateStudent(StudentDict,"Steve",75);
            printData(StudentDict);

            DeleteStudent(StudentDict, "Thor");
            printData(StudentDict);

            printSpecificData(StudentDict,"Tony");


            Console.ReadLine();
        }

        public static void printSpecificData(Dictionary<string, int> studentDict, string name)
        {
            Console.WriteLine("Score of " + name + " is : " + studentDict[name]);
        }

        public static void DeleteStudent(Dictionary<string, int> studentDict, string name)
        {
            studentDict.Remove(name);
            Console.WriteLine(name +" Removed successfully");
        }

        public static void UpdateStudent(Dictionary<string, int> studentDict, string name, int scores)
        {
            studentDict[name] = scores;
            Console.WriteLine("Score updated");
        }

        public static void printData(Dictionary<string, int> studentDict)
        {
            Console.WriteLine("\nThe key and values are \n");
            foreach (var data in studentDict)
            {
                Console.WriteLine(data.Key + " : " +data.Value );
            }

            Console.WriteLine();
        }

        public static void AddStudent(Dictionary<string, int> studentDict, string name, int score)
        {
            studentDict.Add(name, score);
            Console.WriteLine(score + " marks is added to dictionary with its key " + name);
        }
    }
}
