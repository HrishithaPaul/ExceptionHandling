using System;
namespace NullReferenceExceptionHandling
{
    public class Program
    {
        static void Main(string[] args)
        {
            try
            {
                 string Name=null;
                 Console.WriteLine(Name.Length);

            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
