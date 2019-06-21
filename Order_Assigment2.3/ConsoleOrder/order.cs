using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleOrder
{
    class order
    {
        private readonly int orderid;
        private string customername;
        private string itemname;
        private double itemprice;
        private int itemqty;
        public static int counter = 1000;

        public order() { Console.WriteLine("In default contr..."); }
        public order(string customername, string itemname, double itemprice, int itemqty)
        {
            this.orderid = ++order.counter;
            this.customername = customername;
            this.itemname = itemname;
            this.itemprice = itemprice;
            this.itemqty = itemqty;
        }

        public int Orderid
        {
            get
            {
                return this.orderid;
            }
        }

        public string Customername
        {
            get
            {
                return this.customername;
            }

            set
            {
                this.customername = value;
            }
        }

        public string Itemname
        {
            get
            {
                return this.itemname;
            }

            set
            {
                this.itemname = value;
            }
        }

        public double Itemprice
        {
            get
            {
                return this.itemprice;
            }

            set
            {
                this.itemprice = value;
            }
        }

        public int Itemqty
        {
            get
            {
                return this.itemqty;
            }

            set
            {
                this.itemqty = value;
            }
        }

        public double GetOrderAmount()
        {
            return Itemprice*Itemqty;
        }
    }
}
