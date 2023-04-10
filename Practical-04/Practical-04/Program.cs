
using Practical_04;

public class Program
{
    public static void Main()
    {
       
        Student student = new Student();
        student.Name = "Jenish";
        student.Marks = new decimal[5] { 88, 99, 65, 45, 77 };
        int selectedOption;

        Console.WriteLine("-------------------------------------------------------------");
        Console.WriteLine(" 1 - Aggregate: Displays the Name: Average marks \n 2 - MinMark: Displays the minimum marks of the student \n " +
                          "3 - MaximumMark: Displays the maximum mark \n 4 - Grade: Displays grade");
        Console.WriteLine("-------------------------------------------------------------");

        Console.WriteLine("Choose Any One Option:");
      
        bool isNumber = int.TryParse(Console.ReadLine(), out selectedOption);
        if (isNumber)
        {
            decimal avgMarks = student.CalculateAverageMarks();
            switch (selectedOption)
            {
                case (int)Options.Aggregate:
                    Console.WriteLine($"Name: {student.Name}, Average Marks: {avgMarks}");
                    Confirmation();
                    break;
                case (int)Options.MinMark:
                    Console.WriteLine($"Name: {student.Name}, Minimum Marks: {student.Marks.Min()}");
                    Confirmation();
                    break;
                case (int)Options.MaximumMark:
                    Console.WriteLine($"Name: {student.Name}, Maximum Marks: {student.Marks.Max()}");
                    Confirmation();
                    break;
                case (int)Options.Grade:
                    student.CalculateGrade(avgMarks);
                    Confirmation();
                    break;
                default:
                    Console.WriteLine("Wrong Option Chosen");
                    Main();
                    break;
            }
        }
        else
        {
            Console.WriteLine("Please enter valid input");
            Main();
        }
       
    }

    public static void Confirmation()
    {
        Console.WriteLine("-------------------------------------------------------------");
        Console.WriteLine("Are you want to continue: yes or no");
        string input = Console.ReadLine().ToLower();
        if (input == "yes")
        {
            Main();
        }else if (input == "no")
        {
            return;
        }
        else
        {
            Console.WriteLine("-------------------------------------------------------------");
            Console.WriteLine("Please enter valid input");
            Console.WriteLine("-------------------------------------------------------------");
            Confirmation();
        }
    }
}