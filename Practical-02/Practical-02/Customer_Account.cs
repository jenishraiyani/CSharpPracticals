using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical_02
{
    class Customer_Account
    {
        public string bank_name;
        long customer_accountNo;
        string customer_name;

        public Customer_Account(long accountNo, string customerName)
        {
            this.customer_accountNo = accountNo;
            this.customer_name = customerName;
        }

        /// <summary>
        /// This method prints the details of the customers.
        /// </summary>
        /// <remarks>It diplays bank name, account number and name of the customer.</remarks>
        /// <returns>void</returns>
        public void printInfo()
        {
            Console.WriteLine("============== Customer Information ==============");
            Console.WriteLine("Bank Name: {0}", this.bank_name);
            Console.WriteLine("Customer AccountNo: {0}", this.customer_accountNo);
            Console.WriteLine("Customer Name: {0}", this.customer_name);
            Console.WriteLine("==================================================");

        }
    }
}
