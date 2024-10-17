using System;
namespace NullReferenceExceptionHandling
{
    public class Program
    {
        static void Main(string[] args)
        {
            try
            {
                 void Method1()
                {

                }
                Method1();
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
