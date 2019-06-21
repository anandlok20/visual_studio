using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleBook
{
    class Program
    {
        static void Main(string[] args)
        {
            Book b1 = new Book("abc", "anjanay", 2000, 200);
            Console.WriteLine("\nID:"+b1.Bookid+"\nName:"+b1.Booktitle+"\nAuthor:"+b1.Author+"\nPrice:"+b1.Price+"\nNo of Pages:"+b1.Noofpages);
            E_Book b2 = new E_Book("xyz", "anand", 3000, 400, 14, "paperweight");
            Console.WriteLine("\nID:" + b2.Bookid + "\nName:" + b2.Booktitle + "\nAuthor:" + b2.Author + "\nPrice:" + b2.Price + "\nNo of Pages:" + b2.Noofpages+"\nSize:"+b2.Size+"\nFormat:"+b2.Format);
            Console.ReadKey();
        }
    }
}
