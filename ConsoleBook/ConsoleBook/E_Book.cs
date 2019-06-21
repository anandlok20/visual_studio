using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleBook
{
    class E_Book : Book
    {
        int size;
        string format;

        public E_Book(string booktitle, string author, double price, int noofpage,int size, string format)
            :base(booktitle,author,price,noofpage)
        {
            this.size = size;
            this.format = format;
        }

        public int Size
        {
            get
            {
                return this.size;
            }

            set
            {
                this.size = value;
            }
        }

        public string Format
        {
            get
            {
                return this.format;
            }

            set
            {
                this.format = value;
            }
        }
    }
}
