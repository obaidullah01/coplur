using Application2.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application2
{
    public class UserManager
    {
        ISaver _saver = null;

        public UserManager(ISaver saver)
        {
            _saver = saver;
        }   

        public void Saver(List<Customer> user)
        {
             _saver.Saver(user);
        }
    }
}
