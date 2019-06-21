using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleOrder
{
    class Order
    {
        private readonly int orderId;
        private string customerName;
        private int itemQty;
        private double itemPrice;
        public static int counter=2120;

        public Order() { Console.WriteLine("In Order contr1..."); }
        public Order(string customerName, int itemQty, double itemPrice)
        {
            this.orderId = ++Order.counter;
            this.customerName = customerName;
            this.itemQty = itemQty;
            this.itemPrice = itemPrice;
            { Console.WriteLine("In Order contr2..."); }
        }

        public int OrderId
        {
            get
            {
                return orderId;
            }
        }

        public string CustomerName
        {
            get
            {
                return customerName;
            }

            set
            {
                customerName = value;
            }
        }

        public int ItemQty
        {
            get
            {
                return itemQty;
            }

            set
            {
                itemQty = value;
            }
        }

        public double ItemPrice
        {
            get
            {
                return itemPrice;
            }

            set
            {
                itemPrice = value;
            }
        }

        public virtual double GetOrderValue()
        {
            return ItemQty * ItemPrice;
        }
    }
}
