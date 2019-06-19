using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingSystem
{
    class Program
    {
        static int balance;
        static void Main(string[] args)
        {
            Account acc;
            Console.WriteLine("Enter Account Details:\nEnter account id:");
            int id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter customer name:");
            string name = Console.ReadLine();
            Console.WriteLine("Enter customer city:");
            string city = Console.ReadLine();
            acc = new Account(id,name,city);
            Console.WriteLine("Account Id: "+acc.CustomerID+" Customer No:"+acc.CustomerName+" Customer City: "+acc.CustomerCity);
            Boolean x = true;
            int res;
            while (x)
            {
                Console.WriteLine("1.Deposit\n2.Withdraw\n3.CheckBalance\n4.Exit");
                int c = Convert.ToInt32(Console.ReadLine());
                switch (c)
                {
                    case 1:
                        Console.WriteLine("Enter ammount you want to deposit:");
                        res = Convert.ToInt32(Console.ReadLine());
                        balance = balance + res;
                        Console.WriteLine("Balance is: " + balance);
                        break;
                    case 2:
                        Console.WriteLine("Enter ammount you want to withdraw:");
                        res = Convert.ToInt32(Console.ReadLine());
                        if(balance<=0 || (balance-res)<0)
                        {
                            Console.WriteLine("You can not withdraw!!\nInsufficent Balance!!");
                        }
                        else
                        {
                            balance = balance - res;
                        }
                        Console.WriteLine("Balance is: " + balance);
                        break;
                    case 3:
                        Console.WriteLine("Balance is: " + balance);
                        break;
                    case 4:
                        x = false;
                        break;
                    default:
                        Console.WriteLine("Invalid Option!!");
                        break;
                }
            }
        }
    }
}
