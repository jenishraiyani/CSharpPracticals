using System.Xml.Linq;

class Program
{
   
    public static void Main()
    {
        try
        {
            Console.WriteLine("Enter first number: ");
            int firstNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number: ");
            int secondNumber = int.Parse(Console.ReadLine());
            Validation(firstNumber, secondNumber);

        }catch
        {
            Console.WriteLine("Please enter valid numbers");
            Main();
        }
       

    }
    public static void Validation(double firstNumber, double secondNumber)
    {
        if (secondNumber == 0)
        {
            Console.WriteLine("Can not divide by zero");
            Main();
        }
        else
        {
            Calculate(firstNumber, secondNumber);
        }

    }
    public static void Calculate(double firstNumber, double secondNumber)
    {
        double addition = firstNumber + secondNumber;
        double subtraction = firstNumber - secondNumber;
        double multiplication = firstNumber * secondNumber;
        double division = firstNumber / secondNumber;
        Console.WriteLine("================================================================================");
        Console.WriteLine($"The sum of the {firstNumber} and {secondNumber} is {addition}");
        Console.WriteLine($"The subtraction of {firstNumber} and {secondNumber} is {subtraction}");
        Console.WriteLine($"The multiplication  of {firstNumber} and {secondNumber} is {multiplication}");
        Console.WriteLine($"The division of {firstNumber} and {secondNumber} is {division}");
        Console.WriteLine("================================================================================");
        UserConfirmation();
       
    }

    public static void UserConfirmation()
    {
        Console.WriteLine("Do you want to continue (Yes or No)");
        string userResponse = Console.ReadLine().ToLower();
        if (userResponse == "yes")
        {
            Main();
        }
        else if (userResponse == "no")
        {
            return;
        }
        else
        {
            Console.WriteLine("Please enter valid input");
            UserConfirmation();
        }
    }
}