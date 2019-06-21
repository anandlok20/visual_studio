using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleLoan
{
    class VehicleLoan : Loan
    {
        public VehicleLoan(string customerName, string customerEmail, string customerMobile, double loanAmt, int duration, double rate) 
            : base(customerName, customerEmail, customerMobile, loanAmt, duration, rate)
        {
            Console.WriteLine("In VehicleLoan contr..");
        }

        public override double payEMI()
        {
            return LoanAmt + Rate * Duration + 1000;
        }
    }
}
