using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6
{
    public class Program
    {
        static void Main(string[] args)
        {
            Dictionary<Person,string> personDict = new Dictionary<Person,string>();
            for (int i = 1; i <= 3; i++)
            {
                AddToDict(i,personDict);
            }

            printData(personDict);

            UpdateEmail(personDict);
            Console.WriteLine("\nUpdated Dictionary is : ");
            printData(personDict);

            deleteItem(personDict);
            Console.WriteLine("\nUpdated Dictionary is : ");
            printData(personDict);


            Console.ReadLine();
        }

        public static void deleteItem(Dictionary<Person, string> personDict)
        {
            Console.WriteLine("Enter the first Name of the person you want to delete : ");
            string fname = Console.ReadLine();
            foreach (var person in personDict.Keys)
            {
                if (person.FirstName == fname)
                {
                    personDict.Remove(person);
                    Console.WriteLine("Person Deleted \n");
                    return;
                }
            }
            Console.WriteLine("Person not Found !!");
        }

        public static void UpdateEmail(Dictionary<Person, string> personDict)
        {
            Console.WriteLine("Enter the first name of the person you want to update email : ");
            string fname = Console.ReadLine();

            foreach(var person in personDict.Keys)
            {
                if (person.FirstName.Contains(fname))
                {
                    Console.WriteLine("Enter the updated Email : ");
                    personDict[person] = Console.ReadLine();
                    return;
                }
            }
            Console.WriteLine("Person not found");
          
        }

        public static void printData(Dictionary<Person, string> personDict)
        {
            Console.WriteLine("The information is : ");
            foreach (var person in personDict)
            {
                Console.WriteLine(person.Key.FirstName + " " + person.Key.LastName + " : " + person.Value + "@gmail.com");
            }
            Console.WriteLine();
        }

        public static void AddToDict(int i,Dictionary<Person, string> personDict)
        {
            Person person = new Person();
            Console.WriteLine("Enter the First Name of person " + i + " :" );
            person.FirstName = Console.ReadLine();
            Console.WriteLine("Enter the Last Name of person " + i + " :");
            person.LastName = Console.ReadLine();

            Console.WriteLine("Enter the email of person " + i + " :");
            string email = Console.ReadLine();

            Console.WriteLine();

            personDict.Add(person,email);
            return;


        }
    }
}
