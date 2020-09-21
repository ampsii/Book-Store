using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Online_Book_Store
{
    class Login
    {
        private static Login log;
        private Customer LoginCustomer;
        private Login()
        {

        }
        internal Customer LoginCustomer1
        {
            get
            {
                return LoginCustomer;
            }

            set
            {
                LoginCustomer = value;
            }
        }

        public static Login Creator()
        {
            if(log==null)
            {
                log = new Login();
            }
            return log;
        }
    }
}
