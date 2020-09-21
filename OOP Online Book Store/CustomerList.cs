using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Online_Book_Store
{
    class CustomerList
    {
        private static CustomerList Lists;
        public List<Customer> Cstmrlist = new List<Customer>();
        private CustomerList()
        {

        }
       
        public static CustomerList CreateList()
        {
            if(Lists==null)
            {
                Lists = new CustomerList();
            }
            return Lists;
        }
    }
}
