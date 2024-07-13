using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many customer you want? : ");
            int num = Convert.ToInt32(Console.ReadLine());

             List<Customer> customers = new List<Customer>();
            while (num > 0)
            {
                customers.Add(getCustomer());
                num--;
            }

            UserManager manager = new UserManager(new FileSaver());

            Console.WriteLine("Printing the data into the file !");
            manager.Saver(customers);
            Console.ReadLine();
        }

        //public static void writefile(List<Customer> customers)
        //{
        //    foreach (var users in customers)
        //    {
        //        File.AppendAllText("customer.txt", "Name : " + users.name + "\n");
        //        File.AppendAllText("customer.txt", "Age : " + users.age + "\n");
        //        File.AppendAllText("customer.txt", "Email : " + users.email + "\n");
        //        File.AppendAllText("customer.txt", "Phone : " + users.phone + "\n");
        //    }

        //    Console.WriteLine("Information added successfully ");
        //}

        public static Customer getCustomer()
        {
            Customer cust = new Customer();
            Console.WriteLine("Enter name : ");
            cust.name = Console.ReadLine();
            Console.WriteLine("Enter age: ");
            int age = Convert.ToInt32(Console.ReadLine());
            if (!validage(age)) return null;
            cust.age = age;
            Console.WriteLine("Enter email :");
            cust.email = Console.ReadLine();
            Console.WriteLine("Enter phone : ");
            cust.phone = Convert.ToInt32(Console.ReadLine());


            return cust;

        }

        public static bool validage(int age)
        {
            if(age < 18)
            {
                Console.WriteLine("Invalid age ");
                return false;
            }
            return true;
        }
    }
}
