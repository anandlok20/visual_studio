using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleOrder
{
    class Program
    {
        static void Main(string[] args)
        {
            Order o = new Order("Manan",20,2000);
            double res = o.GetOrderValue();
            Console.WriteLine("\nOrder Id:"+o.OrderId+"\nCustomer Name:"+o.CustomerName+"\nItem Qty:"+o.ItemQty+"\nItem Price:"+o.ItemPrice+"\nTotal Price:"+res);
            Order oo = new Order_Overseas("Pooja", 20, 2000);
            res = oo.GetOrderValue();
            Console.WriteLine("\nOrder Id:" + oo.OrderId + "\nCustomer Name:" + oo.CustomerName + "\nItem Qty:" + oo.ItemQty + "\nItem Price:" + oo.ItemPrice + "\nTotal Price:" + res);
            Console.ReadKey();
        }
    }
}
