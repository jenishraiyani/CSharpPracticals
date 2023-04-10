using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical_08
{
    public class ManageFaculty
    {
        List<Faculty> faculties = new List<Faculty>();
        Faculty fct1 = new Faculty()
        {
            Id = 1,
            FullName = "J.K.Raiyani",
            Department = "AI",
            Email = "jenishraiyani90@gmail.com",
            Address = "Rajkot",
            MobileNumber = 7573864415,
            Salary = 88222,
            BankAccount = 983297413264

        }; 
        
        Faculty fct2 = new Faculty()
        {
            Id = 2,
            FullName = "Arjun Patel",
            Department = "ICT",
            Email = "arjunpatel44@gmail.com",
            Address = "Ahmedabad",
            MobileNumber = 9925715020,
            Salary = 99555,
            BankAccount = 140066625228

        };

        public ManageFaculty()
        {
            faculties.Add(fct1);
            faculties.Add(fct2);
        }

        /// <summary>
        /// Return list of all faculty
        /// </summary>
        /// 
        public List<Faculty> GetFaculty()
        {
            return faculties;
        }
    }
}
