using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Practical_08.StudentFeesStructure;

namespace Practical_08
{
    public class ManageStudents : Student
    {
        List<Student> studentsList = new List<Student>();
         
        /// <summary>
        /// Add student in given list
        /// </summary>
        public void AddStudent()
        {

            Console.Write("\t\t\t\tHow many student you want to add: ");
            int len = Convert.ToInt32(Console.ReadLine());
            for(int i=0; i<len; i++)
            {
                Console.WriteLine("\t\t\t\tEnter details of student {0}", i+1);
                Console.Write("\t\t\t\tId: ");
                int studentId = Convert.ToInt32(Console.ReadLine());
                Console.Write("\t\t\t\tFull Name: ");
                string studentName = Console.ReadLine();
                Console.Write("\t\t\t\tDepartment: ");
                string studentDepartment = Console.ReadLine();
                Console.Write("\t\t\t\tGrNumber: ");
                int studentGrNumber = Convert.ToInt32(Console.ReadLine());
                Console.Write("\t\t\t\tEmail: ");
                string studentEmail = Console.ReadLine();
                Console.Write("\t\t\t\tMobile Number: ");
                long studentMobileNumber = Convert.ToInt64(Console.ReadLine());
                Console.Write("\t\t\t\tAddress: ");
                string studentAddress = Console.ReadLine();
                Console.Write("\t\t\t\tStudent Location: ");
                Console.WriteLine("\n\t\t\t\t\t1. Hostel Student");
                Console.WriteLine("\t\t\t\t\t2. City Student");
                Console.Write("\t\t\t\tSelect Option: ");

                string location = "";
                decimal totalFees = 0;
                try
                {
                    int studentStatus = Convert.ToInt32(Console.ReadLine());
                    
                    if (studentStatus == 1)
                    {
                        location = "Hostel";
                        decimal hostelFees = HostelStudentFees.TotalHostelFees();
                        totalFees = HostelStudentFees.TotalHostelFees(hostelFees, 9000);

                    }
                    else if (studentStatus == 2)
                    {
                        location = "City";
                        decimal busFees = CityStudentFees.TotalBusFees();
                        totalFees = CityStudentFees.TotalBusFees(busFees, 15000);

                    }
                    else
                    {
                        Console.WriteLine("Please Enter Valid Input");
                        Program.StudentMenu();
                    }
                }
                catch (FormatException ex)
                {
                    Console.WriteLine("\n\t\t\t\tPlease enter valid input");
                    AddStudent();
                }
                catch (Exception e)
                {
                    Console.WriteLine("\t\t\t\tSomething went wrong: {0}", e.Message);
                    AddStudent();
                }

 
                Student addstudent = new Student()
                {
                    Id = studentId,
                    FullName = studentName,
                    Department = studentDepartment,
                    Email = studentEmail,
                    GrNumber = studentGrNumber,
                    MobileNumber = studentMobileNumber,
                    Address = studentAddress,
                    Status = location,
                    TotalFees = totalFees
                   
                };
                studentsList.Add(addstudent);
                GetStudent();


            }
        }

        /// <summary>
        /// Print list of student
        /// </summary>
        public void GetStudent()
        {
            
            Console.WriteLine("\n\t\t\t\t========================================================");
            Console.WriteLine("\t\t\t\t\t\t Student List");
            Console.WriteLine("\t\t\t\t========================================================");
            if(studentsList.Count > 0)
            {
                foreach (Student std in studentsList)
                {
                    Console.WriteLine($"Id: {std.Id} Name: {std.FullName} Department: {std.Department} Email: {std.GrNumber} " +
                        $"MobileNumber: {std.MobileNumber} Address: {std.Address} Location: {std.Status} TotalFees: {std.TotalFees}");
                }

            }
            else
            {
                Console.WriteLine("\n\t\t\t\tStudent not found!!");
            }
           
            Program.StudentMenu();

        }
    }
}
