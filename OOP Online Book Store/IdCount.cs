using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Online_Book_Store
{
    class IdCount
    {
        private static IdCount Coun;
        private IdCount()
        {

        }
        private int CustumerId = 0;
        private int ProductId = 0;

        public int CustumerId1
        {
            get
            {
                return CustumerId;
            }

            set
            {
                CustumerId = value;
            }
        }

        public int ProductId1
        {
            get
            {
                return ProductId;
            }

            set
            {
                ProductId = value;
            }
        }

        public static IdCount Creator()
        {
            if(Coun==null)
            {
                Coun = new IdCount();
            }
            return Coun;
        }
    }
}
