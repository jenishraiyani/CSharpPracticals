using Practical_06;

class Program
{
    public static void Main(string[] args)
    {
        ProcessBusinessLogic processBusinessLogic = new ProcessBusinessLogic();
        //Assigning the bl_ProcessCompleted method to event, so when event finish it task, it will call bl_ProcessCompleted.
        processBusinessLogic.ProcessCompleted += bl_ProcessCompleted;
        processBusinessLogic.StartProcess();
    }

    /// <summary>
    /// When Process(event) will complete, this method will called.
    /// </summary>
    public static void bl_ProcessCompleted()
    {
        Console.WriteLine("Method Invoked");
    }
}