using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleLoan
{
    abstract class Loan
    {
        protected readonly int loanId;
        protected string customerName;
        protected string customerEmail;
        protected string customerMobile;
        protected double loanAmt;
        protected int duration;
        protected double rate;
        public static int counter = 1200;

        public Loan(string customerName, string customerEmail, string customerMobile, double loanAmt, int duration, double rate)
        {
            this.loanId = ++Loan.counter;
            this.customerName = customerName;
            this.customerEmail = customerEmail;
            this.customerMobile = customerMobile;
            this.loanAmt = loanAmt;
            this.duration = duration;
            this.rate = rate;
        }

        public int LoanId
        {
            get
            {
                return loanId;
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

        public string CustomerEmail
        {
            get
            {
                return customerEmail;
            }

            set
            {
                customerEmail = value;
            }
        }

        public string CustomerMobile
        {
            get
            {
                return customerMobile;
            }

            set
            {
                customerMobile = value;
            }
        }

        public double LoanAmt
        {
            get
            {
                return loanAmt;
            }

            set
            {
                loanAmt = value;
            }
        }

        public int Duration
        {
            get
            {
                return duration;
            }

            set
            {
                duration = value;
            }
        }

        public double Rate
        {
            get
            {
                return rate;
            }

            set
            {
                rate = value;
            }
        }

        public abstract double payEMI();
        public double GetPendingLoan()
        {
            return LoanAmt+Duration*Rate;
        }
    }
}
