using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleOrder
{
    class Order_Overseas : Order
    {
        public Order_Overseas(string customerName, int itemQty, double itemPrice)
            :base(customerName,itemQty,itemPrice)
        { Console.WriteLine("In Order_Overseas contr..."); }

        public override double GetOrderValue()
        {
            return (ItemQty * ItemPrice) * 0.10 + (ItemQty * ItemPrice);
        }
    }
}
