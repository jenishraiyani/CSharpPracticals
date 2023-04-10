using Microsoft.VisualBasic;
using SolidPrincipalsDemo.DIP;
using SolidPrincipalsDemo.ISP;
using SolidPrincipalsDemo.LSP;
using SolidPrincipalsDemo.OCP;
using SolidPrincipalsDemo.SRP;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

class Program
{
    public static void Main(string[] args)
    {

        //InvoiceBeforeSRP invoiceSRP = new InvoiceBeforeSRP();
        //invoiceSRP.AddInvoice();

        //After SRP
        //Invoice invoice = new Invoice();
        //invoice.AddInvoice();

        //Before OCP
        FeesAmountOCP feesAmountOCP = new FeesAmountOCP();
        double fees = feesAmountOCP.GetTotalFeesAmount(44000, StudentType.IndianStudent);
        Console.WriteLine("Before OCP: {0}", fees);

        //After OCP
        FeesAmount indianStudent  = new IndianStudent();
        double IndianStudentFees = indianStudent.GetFeesAmount(44500);
        Console.WriteLine($"Indian Student Fees  : {IndianStudentFees}");

        FeesAmount internationalStudent = new InternationalStudent();
        double InternationalStudentFees = internationalStudent.GetFeesAmount(0);
        Console.WriteLine($"International Student Fees  : {InternationalStudentFees}");

        FeesAmount mysStudent = new MYSStudent();
        double MYSStudent = mysStudent.GetFeesAmount(25000);
        Console.WriteLine($"MYS Student Fees  : {MYSStudent}");


        //Before LSP
        Developer developer = new Tester();
        Console.WriteLine(developer.GetSalary());

        //AfterLSP
        Console.WriteLine("=================================================");
        IStaff salary = new LSPDeveloper();
        Console.WriteLine($"Salary of Developer: {salary.GetSalary()}");
        salary = new LSPTester();
        Console.WriteLine($"Salary of Tester: {salary.GetSalary()}");
 

        //Before ISP
        Console.WriteLine("=================================================");
        HostelStudent hostelStudent = new HostelStudent();
        hostelStudent.HostelFees(65000);
        hostelStudent.UniversityFees(44500);
        hostelStudent.ExamFees(1250);
        hostelStudent.PlacementFees(15000);
        //hostelStudent.BusFees(0);

        //After ISP
        Console.WriteLine("=================================================");
        HostelStudentFees hostelStudentDetails = new HostelStudentFees();
        hostelStudentDetails.HostelFees(65000);
        hostelStudentDetails.UniversityFees(44500);
        hostelStudentDetails.ExamFees(1250);
        hostelStudentDetails.PlacementFees(15000);

        Console.WriteLine("=================================================");
        CityStudentFees cityStudent = new CityStudentFees();
        cityStudent.BusFees(21000);
        cityStudent.UniversityFees(44500);
        cityStudent.ExamFees(1250);
        cityStudent.PlacementFees(15000);


        Console.WriteLine("=================================================");
        //Before DIP
        //Notification notification = new Notification();
        //notification.Send();

        //After DIP
        var message = new List<IMessage>();
        NotificationDIP notificationDIP = new NotificationDIP(message);
        notificationDIP.Send();
        //EmailDIP emailDIP = new NotificationDIP();
        //emailDIP.SendMessage();

    }
}