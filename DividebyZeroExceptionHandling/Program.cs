using System;
namespace DividebyZeroExceptionHandling
{
    public class Program
    {
        static void Main(string[] args)
        {
            try
            {
            int num1=int.Parse(Console.ReadLine());
            int num2=int.Parse(Console.ReadLine());
                if(num2==0)
                {
                    int num3 = num1 / num2;
                }

            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
