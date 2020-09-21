using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Online_Book_Store
{
    class Customer
    {
        private long CustomerID;
        private string Name;
        private string Address;
        private string Email;
        private string Username;
        private string Password;

        public long CustomerID1
        {
            get
            {
                return CustomerID;
            }

            set
            {
                CustomerID = value;
            }
        }

        public string Name1
        {
            get
            {
                return Name;
            }

            set
            {
                Name = value;
            }
        }

        public string Address1
        {
            get
            {
                return Address;
            }

            set
            {
                Address = value;
            }
        }

        public string Email1
        {
            get
            {
                return Email;
            }

            set
            {
                Email = value;
            }
        }

        public string Username1
        {
            get
            {
                return Username;
            }

            set
            {
                Username = value;
            }
        }

        public string Password1
        {
            get
            {
                return Password;
            }

            set
            {
                Password = value;
            }
        }
        public string[] printCustomerDetails()
        {
            string[] printdet = new string[5];
            printdet[0]= CustomerID.ToString();
            printdet[1]= Name;
            printdet[2]= Address;
            printdet[3]= Email;
            printdet[4]= Username;
            return printdet;
    }
    }
}
