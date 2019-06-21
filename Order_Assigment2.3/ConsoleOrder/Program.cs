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
            Console.WriteLine("The product details entered automaticlly!!");
            order o = new order("Amit", "Lays", 20, 3);
            Console.WriteLine("The product details are:");
            double total = o.GetOrderAmount();
            Console.WriteLine("Id:"+o.Orderid+"\nCustomer name:"+o.Customername+"\nItem name:"+o.Itemname+"\nItem price:"+o.Itemprice+"\nItem Quantity:"+o.Itemqty+"\nTotal Price:"+total);
            Console.WriteLine("Do you want to update the quantity(if not enter 0):");
            int c = Convert.ToInt32(Console.ReadLine());
            o.Itemqty = c;
            total = o.GetOrderAmount();
            Console.WriteLine("Id:" + o.Orderid + "\nCustomer name:" + o.Customername + "\nItem name:" + o.Itemname + "\nItem price:" + o.Itemprice + "\nItem Quantity:" + o.Itemqty + "\nTotal Price:" + total);
            Console.ReadKey();
        }
    }
}
