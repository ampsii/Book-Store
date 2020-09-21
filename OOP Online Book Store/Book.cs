using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Online_Book_Store
{
    class Book : Product
    {
        private int ISBNnumber;
        private string author;
        private string publisher;
        private int page;
        public Book()
        {

        }
        public Book(int _Id,string _Name,double _Price,int quantity,int _ISBNnumber,string _Author,string _Publisher,int _Page)
        {
            base.Id = _Id;
            base.Name = _Name;
            base.Price = _Price;
            base.quantity = quantity;
            ISBNnumber = _ISBNnumber;
            author = _Author;
            publisher = _Publisher;
            page = _Page;
        } 
        public int ISBNnumber1
        {
            get
            {
                return ISBNnumber;
            }

            set
            {
                ISBNnumber = value;
            }
        }

        public string Author
        {
            get
            {
                return author;
            }

            set
            {
                author = value;
            }
        }

        public string Publisher
        {
            get
            {
                return publisher;
            }

            set
            {
                publisher = value;
            }
        }

        public int Page
        {
            get
            {
                return page;
            }

            set
            {
                page = value;
            }
        }

        public override string[] printProperties()
        {
            string[] book = new string[8];
            book[0] = base.Id.ToString();
            book[1] = base.Name;
            book[2] = base.Price.ToString();
            book[3] = base.quantity.ToString();
            book[4] = ISBNnumber.ToString();
            book[5] = author;
            book[6] = publisher;
            book[7] = page.ToString();
            return book;
        }
    }
}
