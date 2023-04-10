using Practical_03.Abstraction;
using Practical_03.Inheritance;
using Practical_03.Polymorphism;

class Program
{
    public static void Main(string[] args)
    {
        //Inheritance
        Team team = new Team(" RCB");
        string teamDetails = team.printInfo();
        Console.WriteLine(teamDetails);
      
        //Polymorphism
        Bird myBird= new Bird();
        Duck myDuck= new Duck();
        myBird.Voice();
        myDuck.Voice();

        //Abstraction
        Laptop laptop = new Laptop();
        laptop.Brand = "MSI";
        laptop.Model = "GS63";
        laptop.LaptopDetails();
        //this is private method can not be call
        //laptop.MotherBoardInfo();
    }
}