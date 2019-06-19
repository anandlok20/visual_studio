using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingSystem
{
    internal class Account
    {
        int account_id;
        string cust_name;
        string cust_city;
        
        public Account()
        {
            Console.WriteLine("in contr 1");
        }
        public Account(int account_id, string cust_name, string cust_city)
        {
            Console.WriteLine("in contr 2");
            this.account_id = account_id;
            this.cust_name = cust_name;
            this.cust_city = cust_city;
        }
        public int CustomerID
        {
            get
            {
                return this.account_id;
            }
            set
            {
                this.account_id = value;
            }
        }
        public string CustomerName
        {
            get
            {
                return this.cust_name;
            }
            set
            {
                this.cust_name = value;
            }
        }
        public string CustomerCity
        {
            get
            {
                return this.cust_city;
            }
            set
            {
                this.cust_city = value;
            }
        }
        public string getDetails()
        {
            return "Accout id : " + this.account_id + "Customer Name : " + this.cust_name + "Customer City : " + this.cust_city; 
        }

    }
}
