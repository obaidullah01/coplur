using Application2.Contract;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application2
{
    public class FileSaver : ISaver
    {
        public void Saver(List<Customer> user)
        {
            foreach (var usr in user)
            {
                File.AppendAllText("customer.txt", "Name : " + usr.name + "\n");
                File.AppendAllText("customer.txt", "Age : " + usr.age + "\n");
                File.AppendAllText("customer.txt", "Email : " + usr.email + "\n");
                File.AppendAllText("customer.txt", "Phone : " + usr.phone + "\n");
            }
            Console.WriteLine("Data printed Successfully");
        }
    }
}
