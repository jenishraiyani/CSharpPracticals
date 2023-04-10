using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical_08
{
    public class Faculty
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Department { get; set; }

        private int _salary { get; set; }
        private long _bankAccount { get; set; }
        public string Email { get; set; }
        public long MobileNumber { get; set; }
        public string Address { get; set; }

        public int Salary
        {
            get
            {
                return _salary;
            }
            set
            {
                _salary = value;
            }
        }
        public long BankAccount
        {
            get
            {
                return _bankAccount;
            }
            set
            {
                _bankAccount = value;
            }
        }
    }
}   
