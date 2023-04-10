using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical_08
{
    internal class StudentFeesStructure
    {
      
        interface ICommonFees
        {
            decimal UniversityFees(decimal universityAmount);
            decimal ExamFees(decimal examAmount);
            decimal PlacementFees(decimal placementAmount);
        }
        interface IBusFeesDetails
        {
            decimal BusFees(decimal busAmount);
        }
        interface IHostelFeesDetails
        {
            decimal HostelFees(decimal hostelAmount);
        }

        public class HostelStudentFees : ICommonFees, IHostelFeesDetails
        {
            public decimal UniversityFees(decimal universityAmount)
            {
                return universityAmount;
            }

            public decimal ExamFees(decimal examAmount)
            {
                return examAmount;
            }

            public decimal PlacementFees(decimal placementAmount)
            {
                return placementAmount;
            }
            public decimal HostelFees(decimal hostelAmount)
            {
                return hostelAmount;
            }
            public static decimal TotalHostelFees()
            {
                HostelStudentFees hostelStudentDetails = new HostelStudentFees();
                decimal hostelFees =  hostelStudentDetails.HostelFees(65000);
                decimal universityFees = hostelStudentDetails.UniversityFees(44500);
                decimal examFees = hostelStudentDetails.ExamFees(1250);
                decimal placementFees = hostelStudentDetails.PlacementFees(15000);
                decimal totalFees = hostelFees + universityFees + examFees + placementFees;
                return totalFees;

            }
            public static decimal TotalHostelFees(decimal totalUniversityFees, decimal penalty)
            {
                decimal totalFees = totalUniversityFees + penalty;
                return totalFees;

            }
        }
        
        public class CityStudentFees : ICommonFees, IBusFeesDetails
        {
            public decimal UniversityFees(decimal universityAmount)
            {
                return universityAmount;
            }

            public decimal ExamFees(decimal examAmount)
            {
                return examAmount;
            }
            public decimal PlacementFees(decimal placementAmount)
            {
                return placementAmount;
            }
            public decimal BusFees(decimal busAmount)
            {
                return busAmount;
            }
            public static decimal TotalBusFees()
            {
                CityStudentFees cityStudent = new CityStudentFees();
                decimal busFees = cityStudent.BusFees(21000);
                decimal universityFees = cityStudent.UniversityFees(44500);
                decimal examFees = cityStudent.ExamFees(1250);
                decimal placementFees = cityStudent.PlacementFees(15000);
                decimal totalFees = busFees + universityFees + examFees + placementFees;
                return totalFees;

            }
            public static decimal TotalBusFees(decimal totalBusFees, decimal cityStudent)
            {
                decimal totalFees = cityStudent + cityStudent;
                return totalFees;

            }

        }
    }
}
