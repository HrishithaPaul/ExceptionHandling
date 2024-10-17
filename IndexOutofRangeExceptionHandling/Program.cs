namespace IndexOutofRangeExceptionHandling
{
    public class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int[] arr = { 1, 5, 3, 7, 2 };
                Console.WriteLine(arr[10]);
            }
            catch(IndexOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
