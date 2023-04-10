using Practical_02;

class Program
{
    public static void Main(string[] args)
    {
        Customer_Account customer_Account = new Customer_Account(9925600134, "Jenish");
        customer_Account.bank_name = "SBI";
        customer_Account.printInfo();
    }
}