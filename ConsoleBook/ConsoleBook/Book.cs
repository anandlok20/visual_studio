using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleBook
{
    class Book
    {
        readonly int bookid;
        string booktitle;
        string author;
        double price;
        int noofpages;
        public static int counter = 1000;

        public Book(string booktitle, string author, double price, int noofpages)
        {
            this.bookid = ++Book.counter;
            this.booktitle = booktitle;
            this.author = author;
            this.price = price;
            this.noofpages = noofpages;
        }

        public int Bookid
        {
            get
            {
                return this.bookid;
            }
        }

        public string Booktitle
        {
            get
            {
                return this.booktitle;
            }

            set
            {
                this.booktitle = value;
            }
        }

        public string Author
        {
            get
            {
                return this.author;
            }

            set
            {
                this.author = value;
            }
        }

        public double Price
        {
            get
            {
                return this.price;
            }

            set
            {
                this.price = value;
            }
        }

        public int Noofpages
        {
            get
            {
                return this.noofpages;
            }

            set
            {
                this.noofpages = value;
            }
        }
    }
}
