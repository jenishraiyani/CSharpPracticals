using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical_04
{
    internal class Student
    {
        public string Name;
        public decimal[] Marks = new decimal[5];
        static decimal AverageMarks;

        /// <summary>
        /// Takes all elements from Marks array and calculate average marks
        /// </summary>
        /// <returns></returns>
        public decimal CalculateAverageMarks()
        {
            decimal totalMarks= 0;
            for (int i=0; i<Marks.Length; i++)
            {
                totalMarks= totalMarks + Marks[i];
            }
            AverageMarks =  totalMarks/Marks.Length;
            return AverageMarks;
        }

        /// <summary>
        /// Return grade based on average marks
        /// </summary>
        /// <param name="marks"></param>
        public void CalculateGrade(decimal marks)
        {
            switch (marks)
            {
                case > 90:
                    Console.WriteLine($"Name: {this.Name}, Grade: A");
                    break;
                case > 80:
                    Console.WriteLine($"Name: {this.Name}, Grade: B");
                    break;
                case > 70:
                    Console.WriteLine($"Name: {this.Name}, Grade: C");
                    break;
                case < 70:
                    Console.WriteLine($"Name: {this.Name}, Grade: D");
                    break;
            }
        }
    }
    public enum Options
    {
        Aggregate = 1,
        MinMark = 2,
        MaximumMark = 3,
        Grade = 4
    }
}
