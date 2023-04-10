using Practical_08;
using System.Reflection.PortableExecutable;

class Program
{
    public static void Main()
    {
        Header();
    }
    public static void Header()
    {
        Console.WriteLine("\t\t\t\t========================================================");
        Console.WriteLine("\t\t\t\t\t\tUniversity Management System");
        Console.WriteLine("\t\t\t\t========================================================");
        Console.WriteLine("\n\t\t\t\t1. Manage Faculty");
        Console.WriteLine("\n\t\t\t\t2. Manage Student");
        Console.Write("\n\t\t\t\tChoose Any One Option: ");
        try
        {
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    Console.Clear();
                    FacultyMenu();
                    break;
                case 2:
                    Console.Clear();
                    StudentMenu();
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("\t\t\t\tPlease select valid option");
                    Header();
                    break;
            }
        }catch(FormatException ex)
        {
            Console.Clear();
            Console.WriteLine("\n\t\t\t\tPlease enter valid input");
            Header();
        }catch(Exception e)
        {
            Console.Clear();
            Console.WriteLine("\t\t\t\tSomething went wrong: {0}", e.Message);
            Header();
        }
       
         
    }
    public static void FacultyMenu()
    {
        ManageSalary manageSalary = new ManageSalary();
        TransferSalary transferSalary = new TransferSalary(800000);
       
        Console.WriteLine("\n\t\t\t\t========================================================");
        Console.WriteLine("\t\t\t\t\t\t Manage Faculty");
        Console.WriteLine("\t\t\t\t========================================================");
        Console.WriteLine("\n\t\t\t\t1. Display Salary Details");
        Console.WriteLine("\n\t\t\t\t2. Display All Details");
        Console.WriteLine("\n\t\t\t\t3. Transfer Salary");
        Console.WriteLine("\n\t\t\t\t4. Exit");
        Console.Write("\n\t\t\t\tChoose Any One Option: ");

        try {
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    Console.Clear();
                    manageSalary.GetFacultySalary();
                    break;
                case 2:
                    Console.Clear();
                    manageSalary.GetFacultyDetails();
                    break;
                case 3:
                    Console.Clear();
                    Console.Write("\t\t\t\tPlease Enter Faculty Id: ");
                    int id = Convert.ToInt32(Console.ReadLine());
                    transferSalary.SendSalary(id);
                    break;
                case 4:
                    Console.Clear();
                    Header();
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("\t\t\t\tPlease select valid option");
                    FacultyMenu();
                    break;
            }
        }catch(FormatException ex)
        {
            Console.Clear();
            Console.WriteLine("\n\t\t\t\tPlease enter valid input");
            FacultyMenu();
        }catch (Exception e)
        {
            Console.Clear();
            Console.WriteLine("\t\t\t\tSomething went wrong: {0}", e.Message);
            FacultyMenu();
        }
    }


    public static void StudentMenu()
    {
         ManageStudents manageStudents = new ManageStudents();
      
        Console.WriteLine("\n\t\t\t\t========================================================");
        Console.WriteLine("\t\t\t\t\t\t Manage Student");
        Console.WriteLine("\t\t\t\t========================================================");
        Console.WriteLine("\n\t\t\t\t1. Display Student Details");
        Console.WriteLine("\n\t\t\t\t2. Add Student");
        Console.WriteLine("\n\t\t\t\t3. Exit");
        Console.Write("\n\t\t\t\tChoose Any One Option: ");

        try
        {
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    Console.Clear();
                    manageStudents.GetStudent();
                    break;
                case 2:
                    Console.Clear();
                    manageStudents.AddStudent();
                    break;
                case 3:
                    Console.Clear();
                    Header();
                    break;
                default:
                    Console.WriteLine("\t\t\t\tPlease select valid option");
                    StudentMenu();
                    break;
            }
        }catch (FormatException ex)
        {
            Console.Clear();
            Console.WriteLine("\n\t\t\t\tPlease enter valid input");
            StudentMenu();
        }
        catch (Exception e)
        {
            Console.Clear();
            Console.WriteLine("\t\t\t\tSomething went wrong: {0}", e.Message);
            StudentMenu();
        }
 
    }
}