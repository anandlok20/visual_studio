using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleLoan
{
    class Program
    {
        static void Main(string[] args)
        {
            Loan L = null;
            Console.WriteLine("Select the type of Loan:\n1.Home Loan\n2.Vehicle Loan\n");
            int choice = Convert.ToInt32(Console.ReadLine());
            double res,la;
            if (choice==1)
            {
                L = new HomeLoan("Yogesh", "yogi@bogi.com", "9421231254", 10000, 12, 25);
                res=L.GetPendingLoan();
                la = L.payEMI();
                Console.WriteLine("\nId:"+L.LoanId+"\nCustomer Name:"+L.CustomerName+"\nMobile No:"+L.CustomerMobile+"\nLoan Amount:"+L.LoanAmt+"\nDuration:"+L.Duration+"\nRate:"+L.Rate+"\nPending Loan:"+res+"\nEMI:"+la);
            }
            else if(choice==2)
            {
                L = new VehicleLoan("Dellip", "dilip@bro.com", "9421472554", 10000, 12, 25);
                res = L.GetPendingLoan();
                la = L.payEMI();
                Console.WriteLine("\nId:" + L.LoanId + "\nCustomer Name:" + L.CustomerName + "\nMobile No:" + L.CustomerMobile + "\nLoan Amount:" + L.LoanAmt + "\nDuration:" + L.Duration + "\nRate:" + L.Rate + "\nPending Loan:" + res + "\nEMI:" + la);
            }
            else
            {
                Console.WriteLine("Invalid Choice!!");
            }
            Console.ReadKey();
        }
    }
}
