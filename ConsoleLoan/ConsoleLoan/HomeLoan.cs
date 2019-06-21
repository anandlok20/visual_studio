using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleLoan
{
    class HomeLoan : Loan
    {
        public HomeLoan(string customerName, string customerEmail, string customerMobile, double loanAmt, int duration, double rate) 
            : base(customerName, customerEmail, customerMobile, loanAmt, duration, rate)
        {
            Console.WriteLine("In HomeLoan contr..");
        }

        public override double payEMI()
        {
            return LoanAmt + Rate * Duration + 2000;
        }
    }
}
