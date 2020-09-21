using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Online_Book_Store
{
    class CreditCard : IPayment
    {
        public string paymentconfirmandtype()
        {
            return "Payment is successful with credit card and order is confirmed";
        }
    }
}
