using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical_08
{
    public abstract class Salary
    {
        public abstract void GetFacultySalary();
        public abstract void GetFacultyDetails();
    }

    public class ManageSalary : Salary
    {
        ManageFaculty manageFaculty = new ManageFaculty();

        /// <summary>
        /// Print name and salary of faculty
        /// </summary>
        public override void GetFacultySalary()
        {
            List<Faculty> faculties = manageFaculty.GetFaculty();
            foreach (Faculty fct in faculties)
            {
                Console.WriteLine($"Name: {fct.FullName} Salary: {fct.Salary}"); 
            }
            Program.FacultyMenu();
        } 
        
        /// <summary>
        /// Print all the details of faculty
        /// </summary>
        public override void GetFacultyDetails()
        {
            List<Faculty> faculties = manageFaculty.GetFaculty();
            foreach (Faculty fct in faculties)
            {
                Console.WriteLine($"Name: {fct.FullName} Email: {fct.Email} Department: {fct.Department} Address: {fct.Address} Bank Account: {fct.BankAccount}"); 
            }
            Program.FacultyMenu();
        }
    }


    public class Bonus
    {
        public virtual decimal BonusAmount()
        {
            return 50000;
        }
    }

    public sealed class TransferSalary : Bonus
    {
        private decimal _balance;
        ManageFaculty manageFaculty = new ManageFaculty();

        public TransferSalary(decimal initialBalance)
        {
            _balance = initialBalance;
        }

        public override decimal BonusAmount()
        {
            return 45000;
        }

        /// <summary>
        /// Transer salary to faculty account
        /// </summary>
        public void SendSalary(int id)
        {
            List<Faculty> faculties = manageFaculty.GetFaculty();
            var faculty = faculties.Where(a => a.Id == id).FirstOrDefault();

            if(faculty != null)
            {
                if (_balance >= faculty.Salary)
                {
                    decimal bonus = BonusAmount();
                    _balance -= faculty.BankAccount;
                    Console.WriteLine($"\n\t\t\t\tSalary {faculty.Salary} rupees and Bonus {bonus} is transfered succesfully to account number {faculty.BankAccount}");
                    Program.FacultyMenu();

                }
                else
                {
                    Console.WriteLine("\t\t\t\t Insufficient balance.");
                    Program.FacultyMenu();
                }
            }
            else
            {
                Console.WriteLine("\t\t\t Faculty not found!!");
                Program.FacultyMenu();
            }
        }

    }

}
