using System;
namespace FileNotFoundExcep
{
    public class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int a = 45678976543;
            }
            catch(FileNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
