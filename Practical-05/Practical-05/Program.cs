class Program
{
    public static void Main(string[] args)
    {
        int[] arr = { 100, 101, 102, 103, 104 };

        for(int i=0;i<=arr.Length;i++)
        {
            try
            {
                Console.WriteLine($"Index of Array: {i} : {arr[i]}");
            }catch(IndexOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
            }
            finally{
                Console.WriteLine("This is finally block");
            }
           
        }
    }
}